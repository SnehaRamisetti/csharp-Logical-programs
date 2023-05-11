using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Print the repeated characters in the string
    class Program13
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputStr = Console.ReadLine();
            List<char> repeatedchars = new List<char>();
             foreach (char c in inputStr.Distinct())
            {
                if(inputStr.Count(x=>x==c)>1)
                {
                    repeatedchars.Add(c);
                }
            }
             if(repeatedchars.Count>0)
            {
                Console.WriteLine("Repeated characters:");
                foreach(char c in repeatedchars)
                {
                    Console.WriteLine(c + "");
                }
            }
            else
            {
                Console.WriteLine("No Repeated characters are found");
            }
            
        } 
    }
}
