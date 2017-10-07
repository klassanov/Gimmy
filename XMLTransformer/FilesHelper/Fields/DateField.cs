using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public class DateField : Field<DateTime>
    {
        public string DateFormat { get; set; }
        public static string DefaultDateFormat = "yyyyMMdd";
      
        public DateField(DateTime rawValue, string dateFormat):base(rawValue)
        {
            this.DateFormat = dateFormat??DefaultDateFormat;
        }

        public override string FormattedValue => RawValue.Date.ToString(DateFormat);
    }
}
