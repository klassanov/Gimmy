using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public class CurrencyField: Field
    {
        public decimal RawValue { get; set; }
        public int Precision { get; set; }
       
        public NumberFormatInfo NumberFormat { get; set; }
      

        public CurrencyField(int length): base(length)
        {
            Precision = 2;
            NumberFormat = NumberFormatInfo.InvariantInfo;            
        }

        public CurrencyField(decimal rawValue, int length) : this(length)
        {
            this.RawValue = rawValue;           
        }

       
        public override string FormattedValue => RawValue.ToString(NumberFormat).Replace(NumberFormat.CurrencyDecimalSeparator, string.Empty).PadLeft(Length, ZeroPadChar);
    }
}
