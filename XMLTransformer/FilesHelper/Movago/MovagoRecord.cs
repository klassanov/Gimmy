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
        public List<IField> FieldsList { get; set; }
        public virtual string CodTipoRec { get; set; }
        protected string StrFiller = string.Empty;
        protected int NumFiller = 0;

        public MovagoRecord()
        {
            this.FieldsList = new List<IField>();
            AddFieldsToList();      
        }
        
        protected virtual void AddFieldsToList()
        {
           this.FieldsList.Add(CreateField(CodTipoRec, 1));
        }

        public string GetRecordString()
        {           
            return string.Join(string.Empty, FieldsList.Select(x => x.FormattedValue));
        }

        public IntegerField CreateField(int rawValue, int length)
        {
            return new IntegerField(rawValue, length);
        }

        public CurrencyField CreateField(decimal rawValue, int length)
        {
            return new CurrencyField(rawValue, length);
        }

        public StringField CreateField(string rawValue, int length)
        {
            return new StringField(rawValue, length);
        }

        public DateField CreateField (DateTime rawValue, string dateFormat=null)
        {
            return new DateField(rawValue, dateFormat);
        }
    }
}
