namespace FolderTree
{
    partial class FolderTreeWindow
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(162, 55);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(103, 35);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open Folder";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 55);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 35);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save JSON";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 18);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(253, 22);
            this.pathTextBox.TabIndex = 3;
            // 
            // warning
            // 
            this.warning.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(12, 95);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(253, 19);
            this.warning.TabIndex = 4;
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolderTreeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 123);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Name = "FolderTreeWindow";
            this.Text = "FolderTree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label warning;
    }
}

