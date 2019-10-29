using System;
using System.IO;
using System.Collections.Generic;

namespace FileSystem
{
    class Folder : FileSystemEssence
    {
        private List<Folder> childrens = new List<Folder>();
        private List<File> files = new List<File>();

        public DateTime DateCreated { get; set; }

        public List<Folder> GetChildrens()
        {
            return this.childrens;
        }

        public void SetChildren(Folder folder)
        {
            this.childrens.Add(folder);
        }

        public List<File> GetFiles()
        {
            return this.files;
        }

        public void SetFile(File file)
        {
            this.files.Add(file);
        }

        public Folder(string path)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(path);
            this.Name = currentDirectory.Name;
            this.DateCreated = currentDirectory.CreationTime;

            foreach (FileInfo fileInfo in currentDirectory.GetFiles())
            {
                File file = new File
                {
                    Name = fileInfo.Name,
                    Path = fileInfo.FullName,
                    Size = fileInfo.Length
                };

                SetFile(file);
            }

            foreach (DirectoryInfo directoryInfo in currentDirectory.GetDirectories())
            {
                Folder subFolder = new Folder(directoryInfo.FullName);

                SetChildren(subFolder);
            }

        }
        
    }
}
