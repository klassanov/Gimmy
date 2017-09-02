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
            EasyfattDocuments easyfattDocuments = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EasyfattDocuments));

            //??Validate the file against the schema??
            XmlReaderSettings readerSettings = new XmlReaderSettings()
            {

            };


            using (XmlReader xmlReader = XmlReader.Create(filePath))
            {               
                
                easyfattDocuments= xmlSerializer.Deserialize(xmlReader) as EasyfattDocuments;
            }
            return easyfattDocuments;
        }
    }
}
