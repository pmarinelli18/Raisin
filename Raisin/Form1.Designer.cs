﻿namespace Raisin
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
            this.components = new System.ComponentModel.Container();
            this.txtPrompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.searchFile = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.youtubePrompt = new System.Windows.Forms.Label();
            this.youtubeURL = new System.Windows.Forms.TextBox();
            this.fileDirectory = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrompt
            // 
            this.txtPrompt.AutoSize = true;
            this.txtPrompt.Location = new System.Drawing.Point(62, 56);
            this.txtPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(581, 32);
            this.txtPrompt.TabIndex = 0;
            this.txtPrompt.Text = "Input text to fact check or use Search For File";
            this.txtPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(68, 126);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(678, 262);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchFile
            // 
            this.searchFile.Location = new System.Drawing.Point(906, 126);
            this.searchFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchFile.Name = "searchFile";
            this.searchFile.Size = new System.Drawing.Size(276, 56);
            this.searchFile.TabIndex = 2;
            this.searchFile.Text = "Search For File";
            this.searchFile.UseVisualStyleBackColor = true;
            this.searchFile.Click += new System.EventHandler(this.fileEnter);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(68, 663);
            this.enter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(220, 64);
            this.enter.TabIndex = 4;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // youtubePrompt
            // 
            this.youtubePrompt.AutoSize = true;
            this.youtubePrompt.Location = new System.Drawing.Point(62, 434);
            this.youtubePrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.youtubePrompt.Name = "youtubePrompt";
            this.youtubePrompt.Size = new System.Drawing.Size(300, 32);
            this.youtubePrompt.TabIndex = 5;
            this.youtubePrompt.Text = "Provide a Youtube link";
            this.youtubePrompt.Click += new System.EventHandler(this.label3_Click);
            // 
            // youtubeURL
            // 
            this.youtubeURL.Location = new System.Drawing.Point(68, 496);
            this.youtubeURL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.youtubeURL.Multiline = true;
            this.youtubeURL.Name = "youtubeURL";
            this.youtubeURL.Size = new System.Drawing.Size(678, 72);
            this.youtubeURL.TabIndex = 6;
            // 
            // fileDirectory
            // 
            this.fileDirectory.AutoSize = true;
            this.fileDirectory.Location = new System.Drawing.Point(900, 186);
            this.fileDirectory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileDirectory.Name = "fileDirectory";
            this.fileDirectory.Size = new System.Drawing.Size(0, 32);
            this.fileDirectory.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(68, 620);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 32);
            this.errorMessage.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1360, 769);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.fileDirectory);
            this.Controls.Add(this.youtubeURL);
            this.Controls.Add(this.youtubePrompt);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.searchFile);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtPrompt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Check Your Facts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPrompt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button searchFile;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label youtubePrompt;
        private System.Windows.Forms.TextBox youtubeURL;
        private System.Windows.Forms.Label fileDirectory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label errorMessage;
    }
}

