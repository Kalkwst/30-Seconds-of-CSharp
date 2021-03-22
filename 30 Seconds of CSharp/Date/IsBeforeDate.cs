using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Seconds_of_CSharp.Date
{
    public static partial class DateUtils
    {
        public static bool IsBeforeDate(DateTime dateA, DateTime dateB)
        {
            return dateA < dateB;
        }
    }
}
