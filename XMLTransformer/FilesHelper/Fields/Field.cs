using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public abstract class Field<T>: IField
    {
        public static char ZeroPadChar = '0';
        public static char SpacePadChar = ' ';

        public T RawValue { get; set; }
        public abstract string FormattedValue { get; }
        public int Length { get; set; }

        public Field()
        {                
        }

        public Field(T rawValue)
        {
            this.RawValue = rawValue;
        }

        public Field(T rawValue, int length)
        {
            this.RawValue = rawValue;
            this.Length = length;
        }

       
    }
}
