using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raisin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileEnter(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

                fileDirectory.Text = filePath;
            }
            /* System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
             // This is what will execute if the user selects a folder and hits OK (File if you change to FileBrowserDialog)
             if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 string folder = dlg.SelectedPath;
             }
             else
             {
                 // This prevents a crash when you close out of the window with nothing
             } */
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            //ResultsLogic r = new ResultsLogic(txtInput.Text);
            int count = 0;
        if (youtubeURL.Text != "")
            {
                count++;
            }
        if (fileDirectory.Text != "")
            {
                count++;
            }
        if (txtInput.Text != "")
            {
                count++;
            }
        if (count > 1)
            {
                errorMessage.Text = "Error: Input in only one field";
            }
        else if (count < 1)
            {
                errorMessage.Text = "Error: You must provide input";
            }

        }
    }
}
