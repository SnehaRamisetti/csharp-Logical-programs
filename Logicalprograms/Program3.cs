using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    class Program3
    {
        private static bool isUnique;
        private static string currentchar;

        //Find the unique Character in the String
        static void Main()
        {
            string str = "hello world";
            string uniquechar = "";
             

            for (int i=0;i<str.Length;i++)
            {
                char currentchar = str[i];
                bool isUnique = true;
                for(int j = 0; j< str.Length; j++)
                {
                    if (i != j && currentchar == str[j])
                        isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                uniquechar += currentchar;

            }
            Console.WriteLine("The unique char in the string are:" + uniquechar);
        }

    }
}
