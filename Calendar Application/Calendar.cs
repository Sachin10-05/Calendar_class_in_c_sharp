using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    abstract class Calendar
    {
        public Date Create(int year, int month, int day)
        {
            return new Date(this, year, new YearDate(this, month, day));
        }


        public YearDate Create(int month, int day)
        {
            return new YearDate(this, month, day);
        }


        public abstract string GetName();


        public abstract bool IsLeapYear(int year);
        


        public virtual bool IsLeapDay(int month, int day)
        {
            return (month==2 && day==29);
        }
        

        public virtual int MaxDaysInMonth(int month)
        {
            return (month==2 ? 29
                : month==4 || month==6 || month==9 || month==11 ? 30
                : 31
            );
        }


        public virtual int NextMonth(int afterMonth)
        {
            return afterMonth % 12 + 1;
        }



    }
}
