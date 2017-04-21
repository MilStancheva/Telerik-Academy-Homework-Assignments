using System;
using System.IO;

namespace Problem_3___File_Tree
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine(TraverseFolder(@"..\..\..\"));
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static Folder TraverseFolder(string root)
        {
            var folder = new Folder(root);

            foreach (string file in Directory.GetFiles(root))
            {
                folder.AddFile(new File(file, new FileInfo(file).Length));
            }

            foreach (string directory in Directory.GetDirectories(root))
            {
                folder.AddFolder(TraverseFolder(directory));
            }

            return folder;
        }
    }
}