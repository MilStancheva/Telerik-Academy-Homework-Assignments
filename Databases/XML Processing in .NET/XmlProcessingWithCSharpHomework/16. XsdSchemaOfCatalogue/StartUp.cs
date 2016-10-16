using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace _16.XsdSchemaOfCatalogue
{
    public class StartUp
    {
        public static void Main()
        {
            var xmlUrl = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\catalogue\catalogue.xml";
            var xsdUrl = @"C:\Users\User\Documents\DataBases\XML Processing in .NET\XmlProcessingWithCSharpHomework\16. XsdSchemaOfCatalogue\CatalogueXml\catalogue.xsd";
            var xsdNs = "http://www.w3.org/2001/XMLSchema";

            XmlReaderSettings settings = new XmlReaderSettings();

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(xsdNs, xsdUrl);

            XDocument doc = XDocument.Load(xmlUrl);
            string msg = "";
            doc.Validate(schemas, (o, e) => {
                msg += e.Message + Environment.NewLine;
            });
            Console.WriteLine(msg == "" ? "Document is valid" : "Document invalid: " + msg);
        }
    }
}