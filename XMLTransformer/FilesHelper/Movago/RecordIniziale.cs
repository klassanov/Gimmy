using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Movago
{
    public class RecordIniziale : MovagoRecord
    {
        public override string CodTipoRec { get => "I"; set => base.CodTipoRec = value; }
        public int CFCSOGG { get; set; }
        public int CFNPROGVSCH { get; set; }
        public string Filler = string.Empty;
        public int NumSped { get; set; }
        public DateTime DataSpeed { get; set; }
        public string AppReg { get; set; }

        protected override void CreateFieldsList()
        {         
            this.FieldsList.AddRange(
                new List<IField>()
                {
                    CreateField(CFCSOGG, 15),
                    CreateField(CFNPROGVSCH, 1),
                    CreateField(Filler,6),
                    CreateField(NumSped,10),
                    CreateField(DataSpeed),
                    CreateField(AppReg, 5),
                    CreateField(Filler, 254)
                }
            );
        }

    }
}
