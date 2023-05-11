using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //read a number and print the numbers in ascending order
    class Program17
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of numbers separated by spaces: ");
            string input = Console.ReadLine();

            string[] tokens = input.Split(' ');
            int[] numbers = new int[tokens.Length];
             for (int i=0;i<tokens.Length;i++)
            {
                if(!int.TryParse(tokens[i],out numbers[i]))
                {
                    Console.WriteLine("Invalid input :{0} is not a valid integer.", tokens[i]);
                    return;
                }
            }
            Array.Sort(numbers);
            Console.WriteLine("The numbers in ascending order are:{0}", string.Join(",",numbers));
        }
    }
}
