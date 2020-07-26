using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Days
    {
        public DayOfWeek DayOfWeek { get; set; }
    }

    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
