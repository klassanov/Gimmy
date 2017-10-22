using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FilesHelper.Movago.MovagoEnums;

namespace FilesHelper.Movago
{
    public class MovagoRecordDettaglioFattura : MovagoRecordDettaglio
    {
        public override int CodTipoDett { get => (int)MovagoTipiRecordDettaglio.RIGA_FATTURA; set => base.CodTipoDett = value; }

        public string FACIVA { get; set; }
        public decimal FAIIMPN { get; set; }
        public int SEGIIMP { get; set; }
        public decimal FAIMP { get; set; }
        public int SEGIMP { get; set; }
        public string FACNOR { get; set; }
        public string CACCENCOS { get; set; }
        public string CSotConCosRic_suggest { get; set; }
        public string FACOPERINTRR { get; set; }
        public TipoOperazioneBlackList FACTIPOOPERBLALIST { get; set; }
        public DateTime FADCOMPRIGADA { get; set; }
        public DateTime FADCOMPRIGAA { get; set; }
        public string FAFESLRIGASPL { get; set; }

        protected override void AddFieldsToList()
        {
            base.AddFieldsToList();
            this.FieldsList.AddRange(new List<IField>()
              {
                 CreateField(FACIVA, 2),
                 CreateField(StrFiller, 4),
                 CreateField(FAIIMPN, 16),
                 CreateField(SEGIIMP, 1),
                 CreateField(StrFiller, 4),
                 CreateField(FAIMP, 16),
                 CreateField(SEGIMP, 1),
                 CreateField(FACNOR, 2),
                 CreateField(CACCENCOS, 3),
                 CreateField(CSotConCosRic_suggest, 9),
                 CreateField(FACOPERINTRR, 2),
                 CreateField((int)FACTIPOOPERBLALIST, 3),
                 CreateField(FADCOMPRIGADA),
                 CreateField(FADCOMPRIGAA),
                 CreateField(FAFESLRIGASPL, 1),
                 CreateField(StrFiller, 217)
              }
            );
        }
    }
}
