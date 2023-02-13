using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCoreProg
{
    public  class Power2Number
    {
        public static void CalPower2Num()
        {
            int i;
            int num = 2;
            int N = 31;
            for (i = 0; i <= N; i++)
            {
                double pow = Math.Pow(num, i);
                Console.WriteLine("Calculated 2 power" + i + ":-" + pow);
            }
        }
    }
}
