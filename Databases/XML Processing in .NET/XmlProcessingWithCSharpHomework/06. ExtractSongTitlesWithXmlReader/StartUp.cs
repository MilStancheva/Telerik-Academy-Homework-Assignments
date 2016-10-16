using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05.ExtractSongTitlesWithXmlReader
{
    public class StartUp
    {
        public static void Main()
        {
            var url = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\catalogue.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(url);

            using (var reader = XmlReader.Create(url))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "title")
                        {
                            Console.WriteLine(reader.ReadInnerXml());
                        }
                    }
                }
            }
        }
    }
}
