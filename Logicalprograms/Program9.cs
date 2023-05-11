using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Copy all the elements from one array to another array
    class Program9
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5];
            for (int i = 0; i < arr1.Length; i++) 
            {
                arr2[i] = arr1[i];
            }
            foreach (int j in arr2)
            {
                Console.WriteLine("the copied array is:" + j);
            }
            Console.ReadKey();
        }
    }
}
