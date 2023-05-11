using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //PRINTING ODD AND EVEN NUMBERS FROM AN ARRAY
    class Program10
    {
        static void Main()
        {
            int[] arr = new int[7];
             

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Even numbers are:");
            foreach(int i in arr)
            {
                if(i%2==0)
                {
                    Console.WriteLine(+i);
                }
                
                
            }
            Console.WriteLine("odd numbers are:");
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(+i);
                }


            }
        }
    }
}
