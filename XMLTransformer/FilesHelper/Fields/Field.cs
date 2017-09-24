using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public abstract class Field
    {
        public static char ZeroPadChar = '0';
        public static char SpacePadChar = ' ';

        public abstract string FormattedValue { get; }
        public int Length { get; set; }

        public Field()
        {                
        }

        public Field(int length)
        {
            this.Length = length;
        }
    }
}
