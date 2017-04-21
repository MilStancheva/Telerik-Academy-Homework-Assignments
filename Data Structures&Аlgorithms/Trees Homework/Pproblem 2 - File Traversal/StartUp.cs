using System;
using System.IO;
using System.Linq;

namespace Problem_2___Directory_Traversal
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                TraverseDirectory(@"C:\WINDOWS");
            }
            catch (UnauthorizedAccessException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void TraverseDirectory(string root)
        {
            string extension = ".exe";

            foreach (string file in Directory.GetFiles(root)
                .Where(file => file.EndsWith(extension)))
            {
                Console.WriteLine(file);
            }

            foreach (string directory in Directory.GetDirectories(root))
            {
                TraverseDirectory(directory);
            }
        }
    }
}