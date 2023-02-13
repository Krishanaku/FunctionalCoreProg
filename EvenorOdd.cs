using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCoreProg
{
    public class EvenorOdd
    {
        public static void CheckEvenOdd()
        {
            int num;
            Console.WriteLine("Enter a Number To check Even Or Odd : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number : " + num);


            }
            else
            {
                Console.WriteLine("Odd Number : " + num);
            }
        }

    }
}
