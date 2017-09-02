using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLHelper;

namespace XMLTransformer
{
    public class Test
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Hello world");

            EasyfattDocumentReader reader = new EasyfattDocumentReader();
            EasyfattDocuments documents=reader.ParseXmlDocument();

            Console.ReadKey();
            return 0;
        }
    }
}
