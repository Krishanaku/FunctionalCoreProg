using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCoreProg
{
    public class VowelorConsonant
    {
        public static void CheckVAndCon()
        {
            Char ch;
            Console.WriteLine("Enter Your Character :");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Character is Vowel : " + ch);
            }
            else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Character is Consonant : " + ch);
            }
            else
            {
                Console.WriteLine("Enter a Character to check Vowel And Consonant : ");
            }
        }
    }
}
