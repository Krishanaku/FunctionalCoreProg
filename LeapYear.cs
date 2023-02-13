using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCoreProg
{
    public class LeapYear
    {
        public static void LYearorNot()
        {
            Console.WriteLine("Enter the Year to check is Leap year or not ");
            string year = Console.ReadLine();
            int leapYear = Convert.ToInt32(year);
            Console.WriteLine("You Entered {0}", leapYear);

            if (year.Length < 4)
            {
                Console.WriteLine("Please enter 4 Digit year number");
            }
            else
            {
                if (((leapYear % 4 == 0) && (leapYear % 100 != 0) || (leapYear % 400 == 0)))
                {
                    Console.WriteLine("{0} is a leap year", leapYear);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", leapYear);
                }
            }
        }
    }
}
