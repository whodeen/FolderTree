using System;
using System.IO;
using System.Collections.Generic;

namespace FileSystem
{
    class TreeFolder : FileSystemEssence
    {

        public List<TreeFolder> Children = new List<TreeFolder>();
        public List<TreeFile> Files = new List<TreeFile>();
        public DateTime DateCreated { get; set; }


        public TreeFolder(string path)
        {
            var currentDirectory = new DirectoryInfo(path);
            Name = currentDirectory.Name;
            DateCreated = currentDirectory.CreationTime;

            foreach (var fileInfo in currentDirectory.GetFiles())
            {
                var file = new TreeFile
                {
                    Name = fileInfo.Name,
                    Path = fileInfo.FullName,
                    Size = fileInfo.Length
                };

                Files.Add(file);
            }

            foreach (DirectoryInfo directoryInfo in currentDirectory.GetDirectories())
            {
                var subFolder = new TreeFolder(directoryInfo.FullName);

                Children.Add(subFolder);
            }

        }

    }
}
