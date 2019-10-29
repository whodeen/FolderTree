using System;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using FileSystem;

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
            Folder folder = new Folder(pathTextBox.Text);
            var json = new JavaScriptSerializer().Serialize(folder);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(Stream s = System.IO.File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(json);
                }
            }
        }
    }
}
