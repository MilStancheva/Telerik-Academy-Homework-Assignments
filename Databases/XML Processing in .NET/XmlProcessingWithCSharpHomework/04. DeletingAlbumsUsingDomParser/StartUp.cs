using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04.DeletingAlbumsUsingDomParser
{
    public class StartUp
    {
        public static void Main()
        {
            const decimal MaxPrice = 20.0m;
            var url = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\catalogue.xml";
            var newUrl = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\new-catalogue.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(url);

            XmlElement rootElement = doc.DocumentElement;
            var albums = rootElement.GetElementsByTagName("album");
            var albumsToDelete = new List<XmlNode>();

            foreach(XmlNode album in rootElement.ChildNodes)
            {
                var price = album["price"].InnerText;
                decimal priceAsNumber = decimal.Parse(price);

                if (priceAsNumber > MaxPrice)
                {
                    albumsToDelete.Add(album);
                }
            }

            foreach (var album in albumsToDelete)
            {
                rootElement.RemoveChild(album);
                Console.WriteLine($"Album {album["name"].InnerText} has been removed");
            }

            doc.Save(newUrl);
        }
    }
}
