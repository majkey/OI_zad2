using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using PatternMatching;

namespace RozpoznawanieTwarzy
{
    public partial class Form1 : Form
    {
        Perceptron network;
        int neuronsInFirstLayer;
        double learningRate;
        double momentum;
        double sigmoidAlphaValue;
        double errorRate;
        public const int learningSampleWidth = 32;
        public const int learningSampleHeight = 32;
        protected ArrayList matchs;
        protected NNPatternCheckEditor editor;
        protected PMImage img = null;

        public Form1()
        {
            editor = new NNPatternCheckEditor();
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
                this.img = new PMImage(this.openImageDialog.FileName);
                this.matchs = null;
                this.Refresh();
                this.resetImageButton.Enabled = true;
                if (this.img != null && this.editor.Nnpc != null)
                {
                    this.faceRecogniseButton.Enabled = true;
                }
                else
                    this.faceRecogniseButton.Enabled = false;
            }
        }

        private void resetImageButton_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = this.img.FullImage;
        }

        // ROZPOZNAWANIE TWARZY

        private void faceRecogniseButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (this.editor.Nnpc != null && this.img != null)
            {
                new System.Threading.Thread(new System.Threading.ThreadStart(serchingLearningThread)).Start();
                this.matchs = this.editor.Nnpc.search(img);
                refreshAll();
                this.editor.Nnpc.Listener = null;
                this.Refresh();
            }
            this.imagesListBox.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        public void refreshAll()
        {
            string s;
            this.faceListBox.Items.Clear();
            if (this.matchs != null && this.editor.Nnpc != null)
            {
                PatternMatch pm;
                for (int i = 0; i < matchs.Count; i++)
                {
                    pm = (PatternMatch)matchs[i];
                    s = "Dopasowanie " + i + "; x = " + 8 * (pm.X / 8) + "; y = " + 8 * (pm.Y / 8) + ";";
                    this.faceListBox.Items.Add(s);
                }
                this.statusBarLabel.Text = "Odnaleziono " + this.faceListBox.Items.Count + " obiektów.";
            }
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
            this.statusBarLabel.Text = "Przygotowywanie danych do obróbki...";
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
            this.statusBarLabel.Text = "Uczenie sieci...";
            this.network.learningRate = this.learningRate;
            this.network.momentum = this.momentum;
            this.network.sigmoidAlphaValue = this.sigmoidAlphaValue;
            this.network.neuronsInFirstLayer = this.neuronsInFirstLayer;
            this.network.errorRate = this.errorRate;
            // uczenie sieci neuronowej
            this.network.Learn(input, output);
            this.saveNetworkToFileButton.Enabled = true;
            this.statusBarLabel.Text = "Sieć nauczona!";
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

        // ZAPIS I OCZYT SIECI NEURONOWEJ

        private void loadNetworkFromFileButton_Click(object sender, EventArgs e)
        {
            this.editor.OpenNeuralNetwork();
            this.statusBarLabel.Text = "Sieć wczytana.";
            if (this.img != null && this.editor.Nnpc != null)
            {
                this.faceRecogniseButton.Enabled = true;
            }
            else
                this.faceRecogniseButton.Enabled = false;
        }

        private void saveNetworkToFileButton_Click(object sender, EventArgs e)
        {
            if (this.saveNetworkToFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.network.SaveToFile(this.saveNetworkToFileDialog.FileName);
                this.saveNetworkToFileButton.Enabled = false;
                this.statusBarLabel.Text = "Sieć zapisana!";
            }
        }

        public void serchingLearningThread()
        {
            SerachListenerFrame listen = new SerachListenerFrame();
            editor.Nnpc.Listener = listen;
            Application.Run(listen);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (img != null && matchs == null)
            {
                Bitmap tmp = img.FullImage;
                this.pictureBox.Image = tmp;
                this.pictureBox.Size = tmp.Size;
            }
            else if (img != null && matchs != null)
            {
                Bitmap tmp = img.GetImageMatchs(matchs);
                this.pictureBox.Image = tmp;
                this.pictureBox.Size = tmp.Size;
            }
        }
    }
}
