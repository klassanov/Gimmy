using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public class IntegerField : Field<int>
    {
        public IntegerField(int rawValue, int length): base(rawValue, length)
        {               
        }

        public override string FormattedValue => RawValue.ToString().PadLeft(Length, ZeroPadChar);
    }
}
