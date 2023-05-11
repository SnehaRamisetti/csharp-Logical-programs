using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Find the number of even and odd elements from array
    class Program6
    {
        static void Main()
        {
            int[] arr = new int[5];
            int i, j;
            int even = 0;
            int odd = 0;
             
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            //to find the even
            for (j = 0; j < arr.Length; j++)
            {
                if(arr[j]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
           
            Console.WriteLine("The  number of even numbers array is:" +  even);
            Console.WriteLine("The number of odd numbers array is:" +  odd);
            Console.ReadKey();


        }
    }
}
