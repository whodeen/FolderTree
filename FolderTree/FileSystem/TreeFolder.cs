using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FileSystem
{
    class TreeFolder : FileSystemEssence
    {
        [JsonProperty(PropertyName = "Children", Order = 4)]
        public List<TreeFolder> Children = new List<TreeFolder>();

        [JsonProperty(PropertyName = "Files", Order = 3)]
        public List<TreeFile> Files = new List<TreeFile>();

        [JsonProperty(PropertyName ="DateCreated", Order = 2)]
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
