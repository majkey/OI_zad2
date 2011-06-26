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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.statusBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "uczenie sieci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.groupBox2);
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
            this.pictureBox.Size = new System.Drawing.Size(448, 346);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(6, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 103);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "właściwości";
            // 
            // faceListBox
            // 
            this.faceListBox.Enabled = false;
            this.faceListBox.FormattingEnabled = true;
            this.faceListBox.Location = new System.Drawing.Point(6, 180);
            this.faceListBox.Name = "faceListBox";
            this.faceListBox.Size = new System.Drawing.Size(200, 69);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox faceListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
    }
}

