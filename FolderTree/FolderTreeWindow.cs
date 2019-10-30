using System;
using System.IO;
using System.Windows.Forms;
using FileSystemTree;
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

            var folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = folderBrowserDialog.SelectedPath;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (pathTextBox.Text != "")
            {
                var directoryInfo = new DirectoryInfo(pathTextBox.Text);
                if (directoryInfo.Exists)
                {
                    var saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "JSON Files | *.json";
                    saveFileDialog.DefaultExt = "json";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter file = File.CreateText(saveFileDialog.FileName))
                        {
                            var folder = FolderTreeService.GenerateTree(pathTextBox.Text);
                            var serializer = new JsonSerializer();
                            file.Write(JsonConvert.SerializeObject(folder, Formatting.Indented));
                        }
                    }
                }
                else
                {
                    warning.Text = "Folder path is invalid";
                }
            }
            else
            {
                warning.Text = "Folder path can't be empty";
            }
        }
    }
}
