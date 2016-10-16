using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace _10.TraverseDirectoriesWithXDocument
{
    public class StartUp
    {
        public static void Main()
        {
            var url = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\dir2.xml";

            var desktop = Traverse(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            desktop.Save(url);
        }

        static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
