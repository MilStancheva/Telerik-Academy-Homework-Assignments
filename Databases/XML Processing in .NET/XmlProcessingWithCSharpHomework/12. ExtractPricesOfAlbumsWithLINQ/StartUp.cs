using System;
using System.Linq;
using System.Xml.Linq;

namespace _12.ExtractPricesOfAlbumsWithLINQ
{
    public class StartUp
    {
        public static void Main()
        {
            var url = "C:/Users/User/Documents/DataBases/XML Processing in .NET/catalogue/catalogue.xml";
            var doc = XDocument.Load(url);

            var prices = from album in doc.Descendants("album")
                         where int.Parse(album.Element("year").Value) > 2011
                         select album.Element("price").Value;

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}
