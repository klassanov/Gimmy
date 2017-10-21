using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FilesHelper.Movago.MovagoEnums;

namespace FilesHelper.Movago
{
    public class MovagoRecordDettaglioTestataFattura : MovagoRecordDettaglio
    {

        private bool dittaIndividuale;
        public override int CodTipoDett { get => (int)MovagoTipiRecordDettaglio.TESTATA_FATTURA; set => base.CodTipoDett = value; }
        public int FANATTVIVA { get; set; }
        public int FACSEZNIVA { get; set; }
        public DateTime FADCOMPESPRR { get; set; }
        public string FACCAUS { get; set; }
        public MovimTipoFattura FACTIPOFATT { get; set; }
        public int FANPROT { get; set; }
        public int FANPROTBIS { get; set; }
        public int FANDOCM { get; set; }
        public DateTime FADREGSN { get; set; }
        public DateTime FADDOCM { get; set; }
        public DateTime FADSCADPAGM { get; set; }
        public DateTime FADCOMPDA { get; set; }
        public DateTime FADCOMPA { get; set; }
        public string FACCONDPAGM { get; set; }
        public TipoPagamento FAFPAGMIMMD { get; set; }
        public string FACSOGGCLINFORN { get; set; }
        public string FAXANNTNREGSIVA { get; set; }
        public GenerazionePartita FAFNORATE { get; set; }
        public OpposizioneAssistito FAFOPPSNASSS { get; set; }
        public DateTime FADAUTTR { get; set; }
        public decimal FAIALTRITN { get; set; }
        public decimal FAIRITN { get; set; }
        public TipoIVA FACESIGAIVA { get; set; }
        public string CSotConCliFor_suggest { get; set; }
        public string CSotConDocNonIva_suggesty { get; set; }
        public string FACSPLPAYM { get; set; }
        public decimal FAITOTDOCM { get; set; }
        public TipoFattureRateAperte FACORIG { get; set; }
        public int FANREGSNCOLL { get; set; }
        public int FANREGSN { get; set; }




        public MovagoRecordDettaglioTestataFattura(bool dittaIndividuale) : base()
        {
            this.dittaIndividuale = dittaIndividuale;
        }

        protected override void AddFieldsToList()
        {
            base.AddFieldsToList();
            FieldsList.AddRange(new List<IField>
            {
                CreateField(FANATTVIVA, 2),
                CreateField(FACSEZNIVA, 2),
                CreateField(FADCOMPESPRR),
                CreateField(FACCAUS, 10),
                CreateField((int)FACTIPOFATT, 3),
                CreateField(FANPROT, 10),
                CreateField(FANPROTBIS, 5),
                CreateField(FANDOCM, 15),
                CreateField(FADREGSN),
                CreateField(FADDOCM),
                CreateField(FADSCADPAGM),
                CreateField(FADCOMPDA),
                CreateField(FADCOMPA),
                CreateField(FACCONDPAGM, 5),
                CreateField((int)FAFPAGMIMMD, 1),
                CreateField(FACSOGGCLINFORN, 15),
                CreateField(StrFiller, 21),
                CreateField(FAXANNTNREGSIVA, 30),
                CreateField((int)FAFNORATE, 1),
                CreateField((int)FAFOPPSNASSS, 1),
                CreateField(FADAUTTR),
                CreateField(StrFiller, 4),
                CreateField(FAIALTRITN, 16),
                CreateField(StrFiller, 4),
                CreateField(FAIRITN, 16),
                CreateField((int)FACESIGAIVA, 3),
                CreateField(CSotConCliFor_suggest, 9),
                CreateField(CSotConDocNonIva_suggesty,9),
                CreateField(StrFiller,1),
                CreateField(FACSPLPAYM,3),
                CreateField(FAITOTDOCM,16),
                CreateField((int)FACORIG,3),
                CreateField(FANREGSNCOLL,15),
                CreateField(FANREGSN,15),
                CreateField(StrFiller,6),









            });
        }


    }
}
