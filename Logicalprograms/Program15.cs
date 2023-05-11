using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Convert a string into integer
    class Program15
    {
        static void Main()
        {
            Console.WriteLine("Enter a number as a string");
            string str = Console.ReadLine();
            int num;
            if(int.TryParse(str,out num))
            {
                Console.WriteLine("The string '{0}' can be converted to the integer {1}", str, num);
                    
            }
            else
            {
                Console.WriteLine("The string '{0}' is not a valid integer", str);
            }
        }
    }
}
