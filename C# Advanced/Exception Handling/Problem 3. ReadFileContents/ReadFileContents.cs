using System;
using System.IO;

namespace ReadFileContents
{
    public class ReadFileContents
    {
        public static void Main()
        {
            try
            {
                string path = @"C:\Users\User\Desktop\readfilefromconsoletest.txt";

                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
