using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLHelper
{
    public class EasyfattDocumentReader
    {
        public EasyfattDocuments ParseXmlDocument(string filePath=null)
        {
            filePath = filePath ?? "D:/SW Development/Customers/Gimmy/XML Transformer/Danea_Example.xml";
            string schemaPath = "D:/SW Development/Customers/Gimmy/XML Transformer/easyfatt-xml.xsd";

            EasyfattDocuments easyfattDocuments = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EasyfattDocuments));

            


            //??Validate the file against the schema??
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            
            //readerSettings.Schemas.Add("", schemaPath);
            //readerSettings.ValidationType = ValidationType.Schema;

            //XmlValidatingReader validatingReader=new 

            using (XmlReader xmlReader = XmlReader.Create(filePath))
            { 
              
                easyfattDocuments = xmlSerializer.Deserialize(xmlReader) as EasyfattDocuments;
            }
            return easyfattDocuments;
        }
    }
}
