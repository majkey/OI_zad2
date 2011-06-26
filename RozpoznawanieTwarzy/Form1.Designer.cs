namespace RozpoznawanieTwarzy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.learnNetworkButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picturesBox = new System.Windows.Forms.PictureBox();
            this.resetImagesButton = new System.Windows.Forms.Button();
            this.loadImagesButton = new System.Windows.Forms.Button();
            this.imagesListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sigmoidAlphaValueTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorRateTextBox = new System.Windows.Forms.TextBox();
            this.neuronsInFirstLayerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.momentumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.learningRateTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.faceListBox = new System.Windows.Forms.ListBox();
            this.faceRecogniseButton = new System.Windows.Forms.Button();
            this.resetImageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frameStepTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.frameWidthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frameHeightTextBox = new System.Windows.Forms.TextBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.openImagesDialog = new System.Windows.Forms.OpenFileDialog();
            this.infoLabel = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 405);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(704, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 390);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.infoLabel);
            this.tabPage1.Controls.Add(this.learnNetworkButton);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.resetImagesButton);
            this.tabPage1.Controls.Add(this.loadImagesButton);
            this.tabPage1.Controls.Add(this.imagesListBox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "uczenie sieci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // learnNetworkButton
            // 
            this.learnNetworkButton.Enabled = false;
            this.learnNetworkButton.Location = new System.Drawing.Point(6, 161);
            this.learnNetworkButton.Name = "learnNetworkButton";
            this.learnNetworkButton.Size = new System.Drawing.Size(258, 28);
            this.learnNetworkButton.TabIndex = 7;
            this.learnNetworkButton.Text = "ucz sieć";
            this.learnNetworkButton.UseVisualStyleBackColor = true;
            this.learnNetworkButton.Click += new System.EventHandler(this.learnNetworkButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.picturesBox);
            this.panel2.Location = new System.Drawing.Point(270, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 197);
            this.panel2.TabIndex = 6;
            // 
            // picturesBox
            // 
            this.picturesBox.Location = new System.Drawing.Point(3, 3);
            this.picturesBox.Name = "picturesBox";
            this.picturesBox.Size = new System.Drawing.Size(10, 10);
            this.picturesBox.TabIndex = 0;
            this.picturesBox.TabStop = false;
            // 
            // resetImagesButton
            // 
            this.resetImagesButton.Enabled = false;
            this.resetImagesButton.Location = new System.Drawing.Point(373, 13);
            this.resetImagesButton.Name = "resetImagesButton";
            this.resetImagesButton.Size = new System.Drawing.Size(97, 28);
            this.resetImagesButton.TabIndex = 5;
            this.resetImagesButton.Text = "resetuj";
            this.resetImagesButton.UseVisualStyleBackColor = true;
            this.resetImagesButton.Click += new System.EventHandler(this.resetImagesButton_Click);
            // 
            // loadImagesButton
            // 
            this.loadImagesButton.Location = new System.Drawing.Point(270, 13);
            this.loadImagesButton.Name = "loadImagesButton";
            this.loadImagesButton.Size = new System.Drawing.Size(97, 28);
            this.loadImagesButton.TabIndex = 2;
            this.loadImagesButton.Text = "wczytaj obrazy";
            this.loadImagesButton.UseVisualStyleBackColor = true;
            this.loadImagesButton.Click += new System.EventHandler(this.loadImagesButton_Click);
            // 
            // imagesListBox
            // 
            this.imagesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesListBox.FormattingEnabled = true;
            this.imagesListBox.Location = new System.Drawing.Point(270, 47);
            this.imagesListBox.Name = "imagesListBox";
            this.imagesListBox.Size = new System.Drawing.Size(396, 108);
            this.imagesListBox.TabIndex = 1;
            this.imagesListBox.SelectedIndexChanged += new System.EventHandler(this.imagesListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.sigmoidAlphaValueTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.errorRateTextBox);
            this.groupBox3.Controls.Add(this.neuronsInFirstLayerTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.momentumTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.learningRateTextBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 149);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "parametry sieci";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "wsp. alfa funkcji simoidalnej";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "margines błędu";
            // 
            // sigmoidAlphaValueTextBox
            // 
            this.sigmoidAlphaValueTextBox.Location = new System.Drawing.Point(152, 123);
            this.sigmoidAlphaValueTextBox.Name = "sigmoidAlphaValueTextBox";
            this.sigmoidAlphaValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.sigmoidAlphaValueTextBox.TabIndex = 6;
            this.sigmoidAlphaValueTextBox.TextChanged += new System.EventHandler(this.sigmoidAlphaValueTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "il. neuronów w ukrytej wars.";
            // 
            // errorRateTextBox
            // 
            this.errorRateTextBox.Location = new System.Drawing.Point(152, 97);
            this.errorRateTextBox.Name = "errorRateTextBox";
            this.errorRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.errorRateTextBox.TabIndex = 6;
            this.errorRateTextBox.TextChanged += new System.EventHandler(this.errorRateTextBox_TextChanged);
            // 
            // neuronsInFirstLayerTextBox
            // 
            this.neuronsInFirstLayerTextBox.Location = new System.Drawing.Point(152, 71);
            this.neuronsInFirstLayerTextBox.Name = "neuronsInFirstLayerTextBox";
            this.neuronsInFirstLayerTextBox.Size = new System.Drawing.Size(100, 20);
            this.neuronsInFirstLayerTextBox.TabIndex = 8;
            this.neuronsInFirstLayerTextBox.TextChanged += new System.EventHandler(this.neuronsInFirstLayerTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "wsp. momentum";
            // 
            // momentumTextBox
            // 
            this.momentumTextBox.Location = new System.Drawing.Point(152, 45);
            this.momentumTextBox.Name = "momentumTextBox";
            this.momentumTextBox.Size = new System.Drawing.Size(100, 20);
            this.momentumTextBox.TabIndex = 6;
            this.momentumTextBox.TextChanged += new System.EventHandler(this.momentumTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "wsp. uczenia";
            // 
            // learningRateTextBox
            // 
            this.learningRateTextBox.Location = new System.Drawing.Point(152, 19);
            this.learningRateTextBox.Name = "learningRateTextBox";
            this.learningRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.learningRateTextBox.TabIndex = 4;
            this.learningRateTextBox.TextChanged += new System.EventHandler(this.learningRateTextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.faceListBox);
            this.tabPage2.Controls.Add(this.faceRecogniseButton);
            this.tabPage2.Controls.Add(this.resetImageButton);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.loadImageButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "rozpoznawanie twarzy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(212, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 352);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(10, 10);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // faceListBox
            // 
            this.faceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.faceListBox.Enabled = false;
            this.faceListBox.FormattingEnabled = true;
            this.faceListBox.Location = new System.Drawing.Point(6, 180);
            this.faceListBox.Name = "faceListBox";
            this.faceListBox.Size = new System.Drawing.Size(200, 173);
            this.faceListBox.TabIndex = 6;
            // 
            // faceRecogniseButton
            // 
            this.faceRecogniseButton.Enabled = false;
            this.faceRecogniseButton.Location = new System.Drawing.Point(6, 146);
            this.faceRecogniseButton.Name = "faceRecogniseButton";
            this.faceRecogniseButton.Size = new System.Drawing.Size(200, 28);
            this.faceRecogniseButton.TabIndex = 5;
            this.faceRecogniseButton.Text = "szukaj twarzy";
            this.faceRecogniseButton.UseVisualStyleBackColor = true;
            this.faceRecogniseButton.Click += new System.EventHandler(this.faceRecogniseButton_Click);
            // 
            // resetImageButton
            // 
            this.resetImageButton.Enabled = false;
            this.resetImageButton.Location = new System.Drawing.Point(109, 6);
            this.resetImageButton.Name = "resetImageButton";
            this.resetImageButton.Size = new System.Drawing.Size(97, 28);
            this.resetImageButton.TabIndex = 4;
            this.resetImageButton.Text = "resetuj obraz";
            this.resetImageButton.UseVisualStyleBackColor = true;
            this.resetImageButton.Click += new System.EventHandler(this.resetImageButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.frameStepTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.frameWidthTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.frameHeightTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ramka przesuwna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "krok ramki";
            // 
            // frameStepTextBox
            // 
            this.frameStepTextBox.Location = new System.Drawing.Point(94, 70);
            this.frameStepTextBox.Name = "frameStepTextBox";
            this.frameStepTextBox.Size = new System.Drawing.Size(100, 20);
            this.frameStepTextBox.TabIndex = 5;
            this.frameStepTextBox.TextChanged += new System.EventHandler(this.frameStepTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "szerokość ramki";
            // 
            // frameWidthTextBox
            // 
            this.frameWidthTextBox.Location = new System.Drawing.Point(94, 44);
            this.frameWidthTextBox.Name = "frameWidthTextBox";
            this.frameWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.frameWidthTextBox.TabIndex = 4;
            this.frameWidthTextBox.TextChanged += new System.EventHandler(this.frameWidthTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "wysokość ramki";
            // 
            // frameHeightTextBox
            // 
            this.frameHeightTextBox.Location = new System.Drawing.Point(94, 18);
            this.frameHeightTextBox.Name = "frameHeightTextBox";
            this.frameHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.frameHeightTextBox.TabIndex = 2;
            this.frameHeightTextBox.TextChanged += new System.EventHandler(this.frameHeightTextBox_TextChanged);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(6, 6);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(97, 28);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "wczytaj obraz";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Mapa bitowa|*.bmp|Wszystkie pliki|*.*";
            this.openImageDialog.Title = "Wybór obrazu";
            // 
            // openImagesDialog
            // 
            this.openImagesDialog.FileName = "openImagesDialog";
            this.openImagesDialog.Filter = "Mapa bitowa|*.bmp|Obraz PNG|*.png|Wszystkie pliki|*.*";
            this.openImagesDialog.Multiselect = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(6, 192);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 427);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBar);
            this.Name = "Form1";
            this.Text = "Rozpoznawanie twarzy";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturesBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frameWidthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frameHeightTextBox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button faceRecogniseButton;
        private System.Windows.Forms.Button resetImageButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox frameStepTextBox;
        private System.Windows.Forms.ListBox faceListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox neuronsInFirstLayerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox momentumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox learningRateTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox errorRateTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sigmoidAlphaValueTextBox;
        private System.Windows.Forms.Button loadImagesButton;
        private System.Windows.Forms.ListBox imagesListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picturesBox;
        private System.Windows.Forms.Button resetImagesButton;
        private System.Windows.Forms.OpenFileDialog openImagesDialog;
        private System.Windows.Forms.Button learnNetworkButton;
        private System.Windows.Forms.Label infoLabel;
    }
}

