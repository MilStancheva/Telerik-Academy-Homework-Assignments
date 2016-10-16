using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ExtractArtistsWithDomParser
{
    public class StartUp
    {
        public static void Main()
        {
            var url = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\catalogue.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(url);

            var rootElement = doc.DocumentElement;

            var album = rootElement.FirstChild;
            var artistsAndAlbumsCount = new Dictionary<string, int>();

            while (album != null)
            {
                var albumElement = (XmlElement) album;
                var artist = albumElement["artist"].InnerText;

                if (artistsAndAlbumsCount.ContainsKey(artist))
                {
                    artistsAndAlbumsCount[artist] += 1;
                }
                else
                {
                    artistsAndAlbumsCount.Add(artist, 1);
                }

                album = album.NextSibling;
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

            doc.Save(url);
        }
    }
}
