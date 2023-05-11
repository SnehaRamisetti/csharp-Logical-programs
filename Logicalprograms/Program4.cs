using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Calculate the no.of digits in an integer
    
    class Program4
    {
        static void Main()
        {
            int num;
            int count = 0;
            Console.WriteLine("Enter an interger:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                count++;
                num /= 10;

            }
            Console.WriteLine("The number of digits in an interger:{0}", count);
        }
    }
}
