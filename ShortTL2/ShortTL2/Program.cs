using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create application to print out the day of the week and month
// of the year that match with an integer input at the console by the user.  
// If > 7 for day, print “no corresponding day of the week”. If > 12, same thing.

namespace ShortTL2
{
    class Program
    {
        enum DayofTheWeek { Sunday = 1, Monday = 2, Tuesday = 3, Wednesday=4,
        Thursday=5, Friday=6, Saturday=7};

        enum MonthOfYear { Jan=1, Feb=2, Mar=3, Apr=4, May=5, Jun=6, Jul=7, Aug=8,
        Sept=9, Oct=10, Nov=11, Dec=12}

            static void Main(string[] args)
        {
            int userINput;

            Console.WriteLine("Enter an integer for day of week and month of year: ");
            userINput = int.Parse(Console.ReadLine());

            string day = ((DayofTheWeek)userINput).ToString();
            string month = ((MonthOfYear)userINput).ToString();
            if ((userINput > 7) || (userINput < 1))
            {
                Console.WriteLine("No day of week for value entered");
            }
            else
            {
                Console.WriteLine("Day of the week = " + day);
            }

            if ((userINput > 12) || (userINput < 1))
            {
                Console.WriteLine("No month of year for value entered");
            }
            else
            {
                Console.WriteLine("Month of the Year = " + month);
            }
            Console.ReadLine();

        }
    }
}
