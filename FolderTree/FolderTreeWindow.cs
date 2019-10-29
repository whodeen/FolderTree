using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Folder folder = new Folder(folderBrowserDialog.SelectedPath);
            }

        }
    }
}
