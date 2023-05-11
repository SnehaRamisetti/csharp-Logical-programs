using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Find the Largest and smallest number from an array of random numbers
    class Program19
    {
        static void Main()
        {
            int[] arr = new int[10];
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine("Enter the integer");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("The  smallest number among the integers is " + arr[0]);
            Console.WriteLine("The  Largest number among the integers is " + arr[arr.Length-1]);

        }
    }
}
