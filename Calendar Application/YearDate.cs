using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    class YearDate
    {
        private int _month;
        private int _day;
        private Calendar _calendar;


        public YearDate(Calendar calendar, int month, int day) 
        {
            _calendar = calendar;
            _month= month;
            _day= day;
        }


        public bool IsLeap()
        {
            return _calendar.IsLeapDay(_month, _day);
        }


        public YearDate GetNext()
        {
            return IsEndOfMonth() ? _calendar.Create(_calendar.NextMonth(_month), 1) : _calendar.Create(_month, _day+1);
        }


        private bool IsEndOfMonth() => _day == _calendar.MaxDaysInMonth(_month);


        public bool IsBefore(YearDate other) => (_month < other._month) || (_month==other._month && _day<other._day);


        //This will automatically get invoked bcz it is already created by compiler in base class..
        public override string ToString()
        {
            return (_month + "/" + _day);
        }
    }
}
