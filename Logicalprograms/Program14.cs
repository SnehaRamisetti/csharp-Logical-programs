using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //How many times particular character  is repeated in a string
    class Program14
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the character to search for:");
            char ch = Convert.ToChar(Console.ReadLine());
            int count = 0;
            foreach(char c in str)
            {
                if(c==ch)
                {
                    count++;
                }
            }
            Console.WriteLine("The character {0} appears {1} times in the string.", ch, count);

        }
    }
}
