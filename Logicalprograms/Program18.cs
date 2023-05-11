using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Take 10 integers from the keyboard using loop and print their average value on the screen
    class Program18
    {
        static void Main()
        {
            int sum = 0;
            int num;
            Console.WriteLine("Enter the 10 integers:");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Enter the integer");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            double average = (double)sum/10;
            Console.WriteLine("The average of given numbers is {0}",average);
        }
    }
}
