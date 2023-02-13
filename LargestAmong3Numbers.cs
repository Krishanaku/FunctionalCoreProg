using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCoreProg
{
    public class LargestAmong3Numbers
    {
        public static void FindLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest of three Number!!");
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The First Number Is Greatest Among Three");

                }
                else
                {
                    Console.WriteLine("The Third Number Is Greatest Among Three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The Second Number Is Greatest Among Three");
            }
            else
            {
                Console.WriteLine("The Third Number Is Greatest Among Three");
            }
        }
    }
}
