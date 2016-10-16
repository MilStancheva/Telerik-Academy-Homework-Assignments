using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07.FromTextToXml
{
    public class StartUp
    {
        public static void Main()
        {
            var person = new Person();
            var url = "C:/Users/User/Documents/DataBases/XML Processing in .NET/catalogue/person.txt";
            var newUrl = "C:/Users/User/Documents/DataBases/XML Processing in .NET/catalogue/person.xml";

            using (StreamReader reader = new StreamReader(url))
            {
                person.Name = reader.ReadLine();
                person.Address = reader.ReadLine();
                person.PhoneNumber = reader.ReadLine();
            }

            var personElement = new XElement("person",
                new XElement("name", person.Name),
                new XElement("address", person.Address),
                new XElement("phone", person.PhoneNumber)
                );

            personElement.Save(newUrl);
        }
    }
}
