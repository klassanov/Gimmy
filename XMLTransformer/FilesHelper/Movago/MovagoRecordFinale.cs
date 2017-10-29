using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Movago
{
    public class MovagoRecordFinale: MovagoRecordEstremo
    {
        public override string CodTipoRec { get => "C"; set => base.CodTipoRec = value; }
    }
}
