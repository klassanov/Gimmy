using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Movago
{
    public class RecordIniziale: MovagoRecord
    {
        public override string CodTipoRec { get => "I"; set => base.CodTipoRec = value; }
        public int CFCSOGG { get; set; }
        public int CFNPROGVSCH { get; set; }
        public string Filler1 { get; set; }
        public int NumSped { get; set; }
        public DateTime DataSpeed { get; set; }
        public string AppReg { get; set; }
        public string Filler2 { get; set; }
        
        protected void CreateFieldsList()
        {
            new List<Field>()
            {
                CreateField(CFCSOGG, 1),
                CreateField(CFNPROGVSCH, 15),
                CreateField(Filler1,6),
                CreateField(NumSped,10),
                CreateField(DataSpeed,8),
                

            };
        }

    }
}
