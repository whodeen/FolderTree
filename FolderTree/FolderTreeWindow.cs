using System;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using FileSystem;
using Newtonsoft.Json;

namespace FolderTree
{
    public partial class FolderTreeWindow : Form
    {
        public FolderTreeWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

            //TESTING HOW FOLDER BROWSING WORKS

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = folderBrowserDialog.SelectedPath;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files | *.json";
            saveFileDialog.DefaultExt = "json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter file = System.IO.File.CreateText(saveFileDialog.FileName))
                {
                    Folder folder = new Folder(pathTextBox.Text);
                    JsonSerializer serializer = new JsonSerializer();
                    file.Write(JsonConvert.SerializeObject(folder, Formatting.Indented));
                }
            }
        }
    }
}
