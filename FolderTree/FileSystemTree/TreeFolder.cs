using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FileSystemTree
{
    class TreeFolder : FileSystemEssence
    {
        [JsonProperty(PropertyName = "Children", Order = 4)]
        public List<TreeFolder> Children = new List<TreeFolder>();

        [JsonProperty(PropertyName = "Files", Order = 3)]
        public List<TreeFile> Files = new List<TreeFile>();

        [JsonProperty(PropertyName ="DateCreated", Order = 2)]
        public DateTime DateCreated { get; set; }

    }
}
