using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    internal class Date
    {
        private int year;
        private int month;
        private int day;
        private int totalDays;

        public Date(int year, int month, int day,int totalDays)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.totalDays = totalDays;
        }

        public int Dating()
        {
            totalDays = month + ((year - 1) * 12);
            totalDays = day + ((totalDays - 1) * 31);
            return totalDays;
        }
    }
}
