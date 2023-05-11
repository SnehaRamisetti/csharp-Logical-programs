using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Find the smallest and the Largest number from array
    class Program5
    {
        static void Main()
        {
            int[] arr = new int[5];
            int i, j;
            int small;
            int large;
            for(i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            small = arr[0];
            large = arr[0];
            //to find smallest and largest
            for(j=1;j<arr.Length;j++)
            {
                if(arr[j]<small)
                {
                    small = arr[j];
                }
                if(arr[j]>large)
                {
                    large = arr[j];
                }

            }
            Console.WriteLine("The smallest among the array is:" + small);
            Console.WriteLine("The Largeest among the array is:" + large);
            Console.ReadKey();

        }
    }
}
