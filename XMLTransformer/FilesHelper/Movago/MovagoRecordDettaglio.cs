using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Movago
{
    public class MovagoRecordDettaglio: MovagoRecord
    {
        public override string CodTipoRec { get => "D"; set => base.CodTipoRec = value; }
        public virtual int CodTipoDett { get; set; }                

        protected override void AddFieldsToList()
        {
            base.AddFieldsToList();
            this.FieldsList.Add(CreateField(CodTipoDett, 2));
        }
    }
}
