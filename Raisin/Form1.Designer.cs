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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.searchFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input text to fact check or use look up a file";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(60, 102);
            this.input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(340, 182);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchFile
            // 
            this.searchFile.Location = new System.Drawing.Point(373, 55);
            this.searchFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchFile.Name = "searchFile";
            this.searchFile.Size = new System.Drawing.Size(138, 29);
            this.searchFile.TabIndex = 2;
            this.searchFile.Text = "Search File";
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
            this.enter.Location = new System.Drawing.Point(67, 319);
            this.enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(110, 33);
            this.enter.TabIndex = 4;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 435);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchFile);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Check Your Facts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button searchFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enter;
    }
}

