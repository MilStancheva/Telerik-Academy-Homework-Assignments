using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _11.ExtractPricesOfAlbumsWithXPathQuery
{
    public class StartUp
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();

            var xmlUrl = "C:/Users/User/Documents/DataBases/XML Processing in .NET/catalogue/catalogue.xml";
            doc.Load(xmlUrl);

            string xPathQuery = "/catalogue/album[year > 2011]/price";
            var albumPrices = doc.SelectNodes(xPathQuery);

            foreach (XmlNode price in albumPrices)
            {
                Console.WriteLine(price.InnerText);
            }
        }
    }
}