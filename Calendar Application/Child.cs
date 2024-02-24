using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    class Child
    {
        private string _name;
        private Date _birthdate;
        
        //constructor
        public Child(string name, Date birthdate)
        {
            _name= name;
            _birthdate= birthdate;
        }


        public Date GetDateByAge(int age)
        {
            return _birthdate.AddYear(age);
        }

        public Date GetFirstCelebrationAt(SchoolSystem school)
        {
            return school.GetBeginning(this).GetFirstDayOccurence(_birthdate);
        }

        public override string ToString()
        { 
            return (_name + " born on " + _birthdate); 
        }
    }
}
