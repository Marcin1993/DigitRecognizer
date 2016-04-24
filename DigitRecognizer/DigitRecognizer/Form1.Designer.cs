namespace DigitRecognizer
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
            this.inputImageView = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.outputTextView = new System.Windows.Forms.TextBox();
            this.outputImageView = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.recognitionPage = new System.Windows.Forms.TabPage();
            this.statisticsPage = new System.Windows.Forms.TabPage();
            this.statisticsBox = new System.Windows.Forms.TextBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputImageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.recognitionPage.SuspendLayout();
            this.statisticsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputImageView
            // 
            this.inputImageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputImageView.Location = new System.Drawing.Point(7, 6);
            this.inputImageView.Name = "inputImageView";
            this.inputImageView.Size = new System.Drawing.Size(165, 174);
            this.inputImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputImageView.TabIndex = 1;
            this.inputImageView.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(188, 6);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(156, 41);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // recognizeButton
            // 
            this.recognizeButton.Location = new System.Drawing.Point(188, 53);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(156, 41);
            this.recognizeButton.TabIndex = 3;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            this.recognizeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // outputTextView
            // 
            this.outputTextView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextView.Location = new System.Drawing.Point(6, 212);
            this.outputTextView.Multiline = true;
            this.outputTextView.Name = "outputTextView";
            this.outputTextView.ReadOnly = true;
            this.outputTextView.Size = new System.Drawing.Size(338, 75);
            this.outputTextView.TabIndex = 4;
            // 
            // outputImageView
            // 
            this.outputImageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputImageView.Location = new System.Drawing.Point(236, 100);
            this.outputImageView.Name = "outputImageView";
            this.outputImageView.Size = new System.Drawing.Size(60, 80);
            this.outputImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outputImageView.TabIndex = 5;
            this.outputImageView.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.recognitionPage);
            this.tabControl.Controls.Add(this.statisticsPage);
            this.tabControl.Location = new System.Drawing.Point(1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(358, 320);
            this.tabControl.TabIndex = 6;
            // 
            // recognitionPage
            // 
            this.recognitionPage.Controls.Add(this.inputImageView);
            this.recognitionPage.Controls.Add(this.recognizeButton);
            this.recognitionPage.Controls.Add(this.outputImageView);
            this.recognitionPage.Controls.Add(this.openButton);
            this.recognitionPage.Controls.Add(this.outputTextView);
            this.recognitionPage.Location = new System.Drawing.Point(4, 22);
            this.recognitionPage.Name = "recognitionPage";
            this.recognitionPage.Padding = new System.Windows.Forms.Padding(3);
            this.recognitionPage.Size = new System.Drawing.Size(350, 294);
            this.recognitionPage.TabIndex = 0;
            this.recognitionPage.Text = "Recognize";
            this.recognitionPage.UseVisualStyleBackColor = true;
            // 
            // statisticsPage
            // 
            this.statisticsPage.Controls.Add(this.statisticsBox);
            this.statisticsPage.Controls.Add(this.openFolderButton);
            this.statisticsPage.Location = new System.Drawing.Point(4, 22);
            this.statisticsPage.Name = "statisticsPage";
            this.statisticsPage.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsPage.Size = new System.Drawing.Size(350, 294);
            this.statisticsPage.TabIndex = 1;
            this.statisticsPage.Text = "Test";
            this.statisticsPage.UseVisualStyleBackColor = true;
            // 
            // statisticsBox
            // 
            this.statisticsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statisticsBox.Location = new System.Drawing.Point(146, 16);
            this.statisticsBox.Multiline = true;
            this.statisticsBox.Name = "statisticsBox";
            this.statisticsBox.ReadOnly = true;
            this.statisticsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statisticsBox.Size = new System.Drawing.Size(196, 266);
            this.statisticsBox.TabIndex = 1;
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(8, 15);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(122, 42);
            this.openFolderButton.TabIndex = 0;
            this.openFolderButton.Text = "Test Folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 321);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digit Recognizer";
            ((System.ComponentModel.ISupportInitialize)(this.inputImageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.recognitionPage.ResumeLayout(false);
            this.recognitionPage.PerformLayout();
            this.statisticsPage.ResumeLayout(false);
            this.statisticsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox inputImageView;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.TextBox outputTextView;
        private System.Windows.Forms.PictureBox outputImageView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage recognitionPage;
        private System.Windows.Forms.TabPage statisticsPage;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.TextBox statisticsBox;
    }
}

