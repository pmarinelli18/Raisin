namespace Raisin
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
            this.txtPrompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.searchFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.youtubePrompt = new System.Windows.Forms.Label();
            this.youtubeURL = new System.Windows.Forms.TextBox();
            this.fileDirectory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrompt
            // 
            this.txtPrompt.AutoSize = true;
            this.txtPrompt.Location = new System.Drawing.Point(31, 29);
            this.txtPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(293, 17);
            this.txtPrompt.TabIndex = 0;
            this.txtPrompt.Text = "Input text to fact check or use Search For File";
            this.txtPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(34, 65);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(341, 137);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchFile
            // 
            this.searchFile.Location = new System.Drawing.Point(453, 65);
            this.searchFile.Margin = new System.Windows.Forms.Padding(2);
            this.searchFile.Name = "searchFile";
            this.searchFile.Size = new System.Drawing.Size(138, 29);
            this.searchFile.TabIndex = 2;
            this.searchFile.Text = "Search For File";
            this.searchFile.UseVisualStyleBackColor = true;
            this.searchFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(34, 342);
            this.enter.Margin = new System.Windows.Forms.Padding(2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(110, 33);
            this.enter.TabIndex = 4;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // youtubePrompt
            // 
            this.youtubePrompt.AutoSize = true;
            this.youtubePrompt.Location = new System.Drawing.Point(31, 224);
            this.youtubePrompt.Name = "youtubePrompt";
            this.youtubePrompt.Size = new System.Drawing.Size(150, 17);
            this.youtubePrompt.TabIndex = 5;
            this.youtubePrompt.Text = "Provide a Youtube link";
            this.youtubePrompt.Click += new System.EventHandler(this.label3_Click);
            // 
            // youtubeURL
            // 
            this.youtubeURL.Location = new System.Drawing.Point(34, 256);
            this.youtubeURL.Multiline = true;
            this.youtubeURL.Name = "youtubeURL";
            this.youtubeURL.Size = new System.Drawing.Size(341, 39);
            this.youtubeURL.TabIndex = 6;
            // 
            // fileDirectory
            // 
            this.fileDirectory.AutoSize = true;
            this.fileDirectory.Location = new System.Drawing.Point(471, 100);
            this.fileDirectory.Name = "fileDirectory";
            this.fileDirectory.Size = new System.Drawing.Size(0, 17);
            this.fileDirectory.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 397);
            this.Controls.Add(this.fileDirectory);
            this.Controls.Add(this.youtubeURL);
            this.Controls.Add(this.youtubePrompt);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchFile);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtPrompt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Check Your Facts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPrompt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button searchFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label youtubePrompt;
        private System.Windows.Forms.TextBox youtubeURL;
        private System.Windows.Forms.Label fileDirectory;
    }
}

