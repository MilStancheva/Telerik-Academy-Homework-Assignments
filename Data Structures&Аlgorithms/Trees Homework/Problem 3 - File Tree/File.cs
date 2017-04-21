namespace Problem_3___File_Tree
{
    public class File
    {
        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name { get; private set; }

        public long Size { get; private set; }

        public override string ToString()
        {
            return string.Format("File name: {0} | File size: {1} \n", this.Name, this.Size);
        }
    }
}