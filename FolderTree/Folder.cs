using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Folder : FileSystemEssence
    {
        public DateTime DateCreated { get; set; }
        private List<Folder> childrens;
        private List<File> files;

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

        }
        
    }
}
