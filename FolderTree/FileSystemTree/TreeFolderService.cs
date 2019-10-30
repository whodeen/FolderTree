using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemTree
{
    class TreeFolderService
    {
        public static TreeFolder GenerateTree (string path)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(path);
            var treeFolder = new TreeFolder
            {

                Name = currentDirectory.Name,
                DateCreated = currentDirectory.CreationTime
            };

            foreach (var fileInfo in currentDirectory.GetFiles())
            {
                var file = new TreeFile
                {
                    Name = fileInfo.Name,
                    Path = fileInfo.FullName,
                    Size = fileInfo.Length
                };

                treeFolder.Files.Add(file);
            }

            foreach (DirectoryInfo directoryInfo in currentDirectory.GetDirectories())
            {
                var subFolder = GenerateTree(directoryInfo.FullName);
                treeFolder.Children.Add(subFolder);
            }

            return treeFolder;
        }
    }
}
