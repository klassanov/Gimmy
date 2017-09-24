using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public class IntegerField : Field
    {
        public int RawValue { get; set; }

        public IntegerField(int rawValue, int length): base(length)
        {
            this.RawValue = rawValue;           
        }

        public override string FormattedValue => RawValue.ToString().PadLeft(Length, ZeroPadChar);
    }
}
