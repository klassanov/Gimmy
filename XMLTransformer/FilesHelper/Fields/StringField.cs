using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public class StringField:Field
    {
        public string RawValue { get; set; }       

        public StringField(string rawValue, int length): base(length)
        {
            this.RawValue = rawValue;
            this.Length = length;
        }

        public override string FormattedValue => RawValue.PadRight(Length, SpacePadChar);
    }
}
