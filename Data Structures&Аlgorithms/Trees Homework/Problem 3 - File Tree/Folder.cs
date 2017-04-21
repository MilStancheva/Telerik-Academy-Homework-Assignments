using System.Collections.Generic;
using System.Text;

namespace Problem_3___File_Tree
{
    public class Folder
    {
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; private set; }

        public ICollection<File> Files { get; private set; }

        public ICollection<Folder> ChildFolders { get; private set; }

        public void AddFile(File file)
        {
            this.Files.Add(file);
        }

        public void AddFolder(Folder folder)
        {
            this.ChildFolders.Add(folder);
        }

        public long CalculateSize()
        {
            long result = 0;

            foreach (var file in this.Files)
            {
                result += file.Size;
            }

            foreach (var folder in this.ChildFolders)
            {
                result += folder.CalculateSize();
            }

            return result;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var file in this.Files)
            {
                result.Append(file.ToString());
            }

            foreach (var folder in this.ChildFolders)
            {
                result.Append(folder.ToString());
            }

            return result.ToString();
        }
    }
}