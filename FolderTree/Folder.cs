using System;
using System.IO;
using System.Collections.Generic;

namespace FileSystem
{
    class Folder : FileSystemEssence
    {
        public List<Folder> childrens = new List<Folder>();
        public List<File> files = new List<File>();

        public DateTime DateCreated { get; set; }

     
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

                this.files.Add(file);
            }

            foreach (DirectoryInfo directoryInfo in currentDirectory.GetDirectories())
            {
                Folder subFolder = new Folder(directoryInfo.FullName);

                this.childrens.Add(subFolder);
            }

        }
        
    }
}
