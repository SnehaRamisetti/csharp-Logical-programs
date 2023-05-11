using System;

namespace Logicalprograms
{
    //Check Two String which are reverse of each other or not.
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.WriteLine("Enter first string");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            str2 = Console.ReadLine();
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("The strings are not reverse of each other");
                return;

            }
            for(int i=0;i<str1.Length;i++)
            {
                if (str1[i] != str2[str2.Length - 1 - i])
                {
                    Console.WriteLine("The strings are not reverse of each other");
                    return;
                }
            }
            Console.WriteLine("The string is reverse of each other");
            Console.ReadKey();

        } 
    }
}
