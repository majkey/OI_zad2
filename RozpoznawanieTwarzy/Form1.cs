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
        const int learnSampleWidth = 32;
        const int learnSampleHeihgt = 32;

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
    }
}
