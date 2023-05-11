using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Find the Smallest Sum of consecutive Number from given Array.
    class Program2
      
    {
        static void Main(String[] args)
        {
            int[] arr = {  1,2,3,4};
            int smallestsum = int.MaxValue;
            int currentsum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                currentsum += arr[i];
                if (currentsum < smallestsum)
                {
                    smallestsum = currentsum;
                }
                if (currentsum > 0)
                {
                    currentsum = 0;
                }
            }
            Console.WriteLine("The smallest sum of consecutive numbers in the array is:" + smallestsum);
        }
         
    }
}
