using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    internal class SchoolSystem
    {
        private YearDate _cutoff;
        private int _minAge;
        private YearDate _schoolStart;


        //constructor
        public SchoolSystem(YearDate cutoff, int minAge, YearDate schoolStart)
        {
            _cutoff = cutoff;
            _minAge = minAge;
            _schoolStart = schoolStart;
        }


        //Method to calculate 1st day of child at school
        /*
        public Date GetBeginning(Child schoolchild)
        {
            //steps involved
            //step-1: Get child's birth year
            //step-2: Add minimum age to that
            //step-3: Add one year if birthday is before cutoff date
            //step-4: Append school year beginnig to that date

            Date oldEnough = schoolchild.GetDateByAge(_minAge);
            Date cutoff = oldEnough.GetFirstOccurence(_cutoff);
            Date schoolday = cutoff.GetFirstOccurence(_schoolStart);
            return schoolday;
        }
        */

        //or above method can also be written as-
        //This syntax is known as Expression-bodied Syntax 
        public Date GetBeginning(Child schoolchild) => 
            schoolchild.
                GetDateByAge(_minAge).
                GetFirstOccurence(_cutoff).
                GetFirstOccurence(_schoolStart);
    }
}
