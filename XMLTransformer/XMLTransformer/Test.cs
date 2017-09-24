using FilesHelper;
using FilesHelper.Fields;
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

            CurrencyField nf = new CurrencyField(60.50m, 15);
            StringField sf = new StringField("Lulu", 8);

            Console.WriteLine("Importo formattato: "+nf.FormattedValue);
            Console.WriteLine("Lunghezza: "+nf.FormattedValue.Length);
            Console.WriteLine(sf.FormattedValue);
            Console.WriteLine("Lunghezza: " + sf.FormattedValue.Length);
            /*
            try
            {
                EasyfattDocumentReader reader = new EasyfattDocumentReader();
                EasyfattDocuments documents = reader.ParseXmlDocument();
                TxtFileWriter.WriteFile();
                Logger.Debug("Done!");
            }
            catch (Exception ex)
            {
                Logger.Error("There were some errors", ex);
            }
            */
            Logger.Debug("Finishing");
            Console.ReadKey();
            return 0;
        }
    }
}
