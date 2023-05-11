using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Print only non-repeated digits in an array
    class Program20
    {
        static void Main()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the integer");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> uniqueDigits = new List<int>();
            for(int j=0;j<arr.Length;j++)
            {
                int currentdigit = arr[j];
                int count = 0;
                for (int k = 0; k< arr.Length; k++)
                {
                    if(arr[k]==currentdigit)
                    {
                        count++;
                    }
                }
                if(count==1)
                {
                    uniqueDigits.Add(currentdigit);
                }

            }
            Console.WriteLine("The non-repeated digits are:{0}", string.Join(",", uniqueDigits));

        }
    }
}
