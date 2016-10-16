using System;
using System.Linq;
using System.Xml;

namespace _08.ReadAndWriteXml
{
    public class StartUp
    {
        public static void Main()
        {
            var url = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\catalogue.xml";
            var newUrl = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\album.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            string albumName = string.Empty;
            string artistName = string.Empty;


            using (var writer = XmlWriter.Create(newUrl))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("albums"); 

                using (var reader = XmlReader.Create(url))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            if (reader.Name == "name")
                            {
                                albumName = reader.ReadInnerXml();
                                writer.WriteStartElement("album");
                                writer.WriteStartElement("name");
                                writer.WriteString(albumName);
                                writer.WriteEndElement();
                            }

                            if (reader.Name == "artist")
                            {
                                artistName = reader.ReadInnerXml();
                                writer.WriteStartElement("artist");
                                writer.WriteString(artistName);
                                writer.WriteEndElement();
                                writer.WriteEndElement();
                            }
                        }
                    }
                }

                writer.WriteEndDocument();
            }
        }
    }
}
