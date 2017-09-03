using log4net;
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
        public static ILog Logger = LogManager.GetLogger(typeof(Test));

        public static int Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();           
            Logger.Debug("Starting");

            try
            {
                EasyfattDocumentReader reader = new EasyfattDocumentReader();
                EasyfattDocuments documents = reader.ParseXmlDocument();               
                Logger.Debug("Done!");
            }
            catch (Exception ex)
            {
                Logger.Error("There were some errors", ex);
            }           
            Logger.Debug("Finishing");
            Console.ReadKey();
            return 0;
        }
    }
}
