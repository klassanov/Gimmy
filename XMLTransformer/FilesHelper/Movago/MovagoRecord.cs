using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Movago
{
    public class MovagoRecord
    {
        public IEnumerable<Field> FieldsList { get; set; }
        public virtual string CodTipoRec { get; set; }

        public MovagoRecord()
        {
           
        }

        public string GetRecordString()
        {
            return string.Join(string.Empty, FieldsList.Select(x => x.FormattedValue));
        }

        public Field CreateField(int rawValue, int length)
        {
            return new IntegerField(rawValue, length);
        }

        public Field CreateField(decimal rawValue, int length)
        {
            return new CurrencyField(rawValue, length);
        }

        public Field CreateField(string rawValue, int length)
        {
            return new StringField(rawValue, length);
        }
    }
}
