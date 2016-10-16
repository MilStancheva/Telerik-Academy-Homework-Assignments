using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _06.ExtractSongTitlesWithLINQ
{
    public class StartUp
    {
        public static void Main()
        {
            var url = "C:/Users/User/Documents/DataBases/XML Processing in .NET/catalogue/catalogue.xml";
            var doc = XDocument.Load(url);

            var albums = doc.Root.Elements("album");

            var titles = from title in albums.Descendants("title")
                         select title.Value;

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
