using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    internal class Program
    {
        static void Report(Child[] children, SchoolSystem school)
        {
            foreach (Child c in children)
            {
                Console.WriteLine(c + " starts school on " + school.GetBeginning(c) + ", celebrates on " + c.GetFirstCelebrationAt(school));
            }
        }


        static void Demonstrate(Calendar cal) 
        {
            SchoolSystem school = new SchoolSystem(cal.Create(3, 1), 5, cal.Create(8, 15));

            //Array
            Child[] children = new Child[2];
            children[0] = new Child("Jill", cal.Create(1892, 2, 29));
            children[1] = new Child("Jake", cal.Create(1891, 8, 27));

            Console.WriteLine("using " + cal.GetName() + " calendar:");

            Report(children, school);

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Calendar[] cal = new Calendar[]
            {
                new GregorianCalendar(),
                new JulianCalendar()
            };

            foreach(Calendar c in cal) 
            {
                Demonstrate(c);
            }
            Console.ReadLine();
        }
    }
}
