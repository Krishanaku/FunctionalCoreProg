using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCoreProg
{
    public class QuotientandRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            Console.WriteLine("Enter a Value to QuotientAndRemainder ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend : {0} Divisor : {1}", divisor, quotient);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
