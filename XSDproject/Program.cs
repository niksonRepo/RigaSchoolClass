using System;
using System.Xml;
using System.Xml.Schema;

namespace XSDproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XML schema validation");
            
            //var xmlDoc = @"xmFile.xml";
            //var xsdDoc = @"xsdFile.xsd";
            var xmlDoc = @"DanutasXML.xml";
            var xsdDoc = @"DanutasXSD.xsd";

            try
            {
                Console.WriteLine(ValidateSchema(xmlDoc, xsdDoc) ? "XML schema is valid" : "XML schema is invalid");
                Console.ReadLine();
            }
            catch (XmlSchemaValidationException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static bool ValidateSchema(string xmlPath, string xsdPath)
        {
            var xml = new XmlDocument();

            xml.Load(xmlPath);
            xml.Schemas.Add(null, xsdPath);

            xml.Validate(null);

            return true;
        }
    }
}
