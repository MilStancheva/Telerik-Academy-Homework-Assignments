using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ExtractArtistsWithXPath
{
    public class StartUp
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();

            var xmlUrl = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\catalogue.xml";
            doc.Load(xmlUrl);
            
            string xPathQuery = "catalogue/album/artist";

            var artistsList = doc.SelectNodes(xPathQuery);

            var artistsAndAlbumsCount = new Dictionary<string, int>();
            
            foreach (XmlElement artistNode in artistsList)
            {
                var artistName = artistNode.InnerText;

                if (artistsAndAlbumsCount.ContainsKey(artistName))
                {
                    artistsAndAlbumsCount[artistName] += 1;
                }
                else
                {
                    artistsAndAlbumsCount.Add(artistName, 1);
                }
            }

            foreach (var artist in artistsAndAlbumsCount)
            {
                Console.Write($"{artist.Key} have {artist.Value} ");
                if (artist.Value > 1)
                {
                    Console.WriteLine("albums");
                }
                else
                {
                    Console.WriteLine("album");
                }
            }

            doc.Save(xmlUrl);
        }
    }
}