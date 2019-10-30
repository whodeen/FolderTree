using Newtonsoft.Json;

namespace FileSystem
{
    class TreeFile : FileSystemEssence
    {
        [JsonProperty(PropertyName = "Size", Order = 2)]
        public long Size { get; set; }
        [JsonProperty(PropertyName = "Path", Order = 3)]
        public string Path { get; set; }

        public TreeFile()
        {

        }
    }
}
