using FilesHelper;
using FilesHelper.Fields;
using FilesHelper.Movago;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLHelper;
using static FilesHelper.Movago.MovagoEnums;

namespace XMLTransformer
{
    public class Test
    {
        public static ILog Logger = LogManager.GetLogger(typeof(Test));

        public static int Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            Logger.Debug("Starting");

            //MovagoRecordIniziale r = new MovagoRecordIniziale()
            //{
            //    CFCSOGG=999999,
            //    CFNPROGVSCH=TipoProgressivoScheda.ORDINARIA,
            //    NumSped=86,
            //    DataSpeed=new DateTime(),
            //    AppReg="LULU"


            //};




            try
            {
                //EasyfattDocumentReader reader = new EasyfattDocumentReader();
                //EasyfattDocuments documents = reader.ParseXmlDocument();
                //TxtFileWriter.WriteFile(r);

                IEnumerable<MovagoRecord> recordList = new List<MovagoRecord> {
                     new MovagoRecordIniziale(),
                     new MovagoRecordDettaglioTestataFattura(),
                     new MovagoRecordDettaglioFattura(),
                     new MovagoRecordFinale()
                };

                MovagoFileWriter.WriteFile(recordList);

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
