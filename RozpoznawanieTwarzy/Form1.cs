using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RozpoznawanieTwarzy
{
    public partial class Form1 : Form
    {
        Bitmap sourceBitmap;
        Perceptron network;
        int frameHeight;
        int frameWidth;
        int frameStep;
        int neuronsInFirstLayer;
        double learningRate;
        double momentum;
        double sigmoidAlphaValue;
        double errorRate;
        public const int learningSampleWidth = 32;
        public const int learningSampleHeight = 32;

        public Form1()
        {
            InitializeComponent();
            this.statusBarLabel.Text = "";
            this.network = new Perceptron();
        }

        // =================================== ROZPOZNAWANIE TWARZY ===================================

        // WCZYTYWANIE OBRAZÓW

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            if (this.openImageDialog.ShowDialog() == DialogResult.OK)
            {
                sourceBitmap = new Bitmap(this.openImageDialog.FileName);
                this.pictureBox.Width = sourceBitmap.Width;
                this.pictureBox.Height = sourceBitmap.Height;
                this.pictureBox.Image = sourceBitmap;
                this.resetImageButton.Enabled = true;
                enableFaceRecogniseButton();
            }
        }

        private void resetImageButton_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = this.sourceBitmap;
        }

        // WALIDACJA PARAMETRÓW

        private void enableFaceRecogniseButton()
        {
            if (int.TryParse(this.frameWidthTextBox.Text, out this.frameWidth) &&
                int.TryParse(this.frameHeightTextBox.Text, out this.frameHeight) &&
                int.TryParse(this.frameStepTextBox.Text, out this.frameStep) &&
                this.pictureBox.Image != null)
                this.faceRecogniseButton.Enabled = true;
            else
                this.faceRecogniseButton.Enabled = false;
        }

        private void frameHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            enableFaceRecogniseButton();
        }

        private void frameWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            enableFaceRecogniseButton();
        }

        private void frameStepTextBox_TextChanged(object sender, EventArgs e)
        {
            enableFaceRecogniseButton();
        }

        // ROZPOZNAWANIE TWARZY

        private void faceRecogniseButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ImageSupport imsu = new ImageSupport((Bitmap)this.pictureBox.Image);
            imsu.sampleWidth = this.frameWidth;
            imsu.sampleHeight = this.frameHeight;
            imsu.offsetStep = this.frameStep;
            imsu.learningSampleWidth = learningSampleWidth;
            imsu.learningSampleHeight = learningSampleHeight;
            double [] sample;
            int x = 0;
            int y = 0;
            do
            {
                while ((sample = imsu.GetLearningSample(x, y)) != null)
                {
                    imsu.DrawFrameOnResultImage(x, y);
                    x++;
                }
                x = 0; y++;
            } while (sample != imsu.GetLearningSample(x, y));
            this.pictureBox.Image = imsu.resultImage;
            this.Cursor = Cursors.Default;
        }

        // =================================== UCZENIE SIECI ===================================

        // WCZYTYWANIE OBRAZÓW

        private void loadImagesButton_Click(object sender, EventArgs e)
        {
            if (this.openImagesDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in this.openImagesDialog.FileNames)
                    this.imagesListBox.Items.Add(file);
                enableLearnNetworkButton();
                this.resetImagesButton.Enabled = true;
            }
        }

        private void imagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap((string)this.imagesListBox.SelectedItem);
            this.picturesBox.Width = bitmap.Width;
            this.picturesBox.Height = bitmap.Height;
            this.picturesBox.Image = bitmap;
        }

        private void resetImagesButton_Click(object sender, EventArgs e)
        {
            this.imagesListBox.Items.Clear();
            this.picturesBox.Image = null;
            this.resetImagesButton.Enabled = false;
        }

        private void learnNetworkButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.infoLabel.Text = "";
            // przygotowanie tablicy danych wejściowych
            double[][] input;
            List<double[]> data = new List<double[]>();
            foreach (string path in this.imagesListBox.Items)
            {
                DataFile df = new DataFile(path.Split('.')[0] + ".txt");
                ImageSupport imsu = new ImageSupport(new Bitmap(path));
                foreach (Rectangle r in df.data)
                    data.Add(ImageSupport.Normalize(imsu.GetLearningSample(r)));
            }
            input = new double [data.Count][];
            for (int i = 0; i < data.Count; i++)
                input[i] = data[i];
            // tworzenie tablicy danych wyjściowych
            double[][] output = new double[input.Length][];
            for (int i = 0; i < data.Count; i++)
            {
                int size = 1;
                output[i] = new double[size];
                for(int j = 0; j < size; j++)
                    output[i][j] = 1.0;
            }
            // ustawienia sieci neuronowej
            this.network.learningRate = this.learningRate;
            this.network.momentum = this.momentum;
            this.network.sigmoidAlphaValue = this.sigmoidAlphaValue;
            this.network.neuronsInFirstLayer = this.neuronsInFirstLayer;
            this.network.errorRate = this.errorRate;
            // uczenie sieci neuronowej
            this.network.Learn(input, output);
            this.Cursor = Cursors.Default;
        }

        // WALIDACJA PARAMETRÓW

        private void enableLearnNetworkButton()
        {
            if (double.TryParse(this.learningRateTextBox.Text, out this.learningRate) &&
                double.TryParse(this.momentumTextBox.Text, out this.momentum) &&
                double.TryParse(this.sigmoidAlphaValueTextBox.Text, out this.sigmoidAlphaValue) &&
                double.TryParse(this.errorRateTextBox.Text, out this.errorRate) &&
                int.TryParse(this.neuronsInFirstLayerTextBox.Text, out this.neuronsInFirstLayer) &&
                this.imagesListBox.Items.Count > 0)
            {
                this.learnNetworkButton.Enabled = true;
            }
            else
            {
                this.learnNetworkButton.Enabled = false;
            }
        }

        private void learningRateTextBox_TextChanged(object sender, EventArgs e)
        {
            enableLearnNetworkButton();
        }

        private void momentumTextBox_TextChanged(object sender, EventArgs e)
        {
            enableLearnNetworkButton();
        }

        private void neuronsInFirstLayerTextBox_TextChanged(object sender, EventArgs e)
        {
            enableLearnNetworkButton();
        }

        private void errorRateTextBox_TextChanged(object sender, EventArgs e)
        {
            enableLearnNetworkButton();
        }

        private void sigmoidAlphaValueTextBox_TextChanged(object sender, EventArgs e)
        {
            enableLearnNetworkButton();
        }
    }
}
