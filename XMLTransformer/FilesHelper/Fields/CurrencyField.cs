using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public class CurrencyField: Field<decimal>
    {     
        public int Precision { get; set; }       
        public NumberFormatInfo NumberFormat { get; set; }      

        public CurrencyField(decimal rawValue, int length): base(rawValue, length)
        {
            Precision = 2;
            NumberFormat = NumberFormatInfo.InvariantInfo;            
        }
       
        public override string FormattedValue => RawValue.ToString(NumberFormat).Replace(NumberFormat.CurrencyDecimalSeparator, string.Empty).PadLeft(Length, ZeroPadChar);
    }
}
