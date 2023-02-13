using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCoreProg
{
    public class SwapTwoNumbers
    {
        public static void SwapNumber()
        {
            Console.WriteLine("Enter a value to check Swap number");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap a = " + a + " b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After Swap a = " + a + " b = " + b);
        }
    }
}
