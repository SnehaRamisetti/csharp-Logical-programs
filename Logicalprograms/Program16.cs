using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //read a name and print the letters in ascending order
    class Program16
    {
        static void Main()
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            char[] letters = new char[name.Length];
            for( int i=0;i<name.Length;i++)
            {
                letters[i] = name[i];
            }
            Array.Sort(letters);
            Console.WriteLine("The letters in {0} in ascending order are:{1}" , name,new string(letters));
        }
    }
}
