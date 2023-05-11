using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{ 
    //Find length of string without using function
    class Program8
    {
        static void Main()
        {
            string str;
            int len=0;
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
             foreach(char ch in str)
            {
                len++;
            }
            Console.WriteLine("The Length of the string is : " + len);
            Console.ReadKey();
        }
    }
}
