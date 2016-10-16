using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace _13.XslStylesheet
{
    public class StartUp
    {
        public static void Main()
        {
            var xmlUrl = "C:/Users/User/Documents/DataBases/XML Processing in .NET/catalogue/catalogue.xml";
            var xslUrl = "C:/Users/User/Documents/DataBases/XML Processing in .NET/catalogue/template.xsl";
            var htmlUrl = "C:/Users/User/Documents/DataBases/XML Processing in .NET/catalogue/catalogue.html";

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xslUrl);
            xslt.Transform(xmlUrl, htmlUrl);
        }
    }
}
