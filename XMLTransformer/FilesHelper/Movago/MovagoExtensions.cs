using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Movago
{
   public static class MovagoExtensions
    {
        public static string[] ToStringArray(this IEnumerable<MovagoRecord> recordList)
        {
            return (recordList != null && recordList.Count() > 0)
                ? recordList.Select(x => x.GetRecordString()).ToArray()
                : null;
        }
    }
}
