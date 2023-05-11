using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Find the unique character in the string
    class Program12
    {
        static void Main()
        {
            string inputstr = "Sneha durga";
            Console.WriteLine("Input String: " +inputstr);
            Console.WriteLine("Unique characters list: \n");
            UniqueCharacter(inputstr);


        }
        public static void UniqueCharacter(string str)
        {
            var charCountResult = CharcountDictionary(str);
            foreach( var count in charCountResult)
            {
                if(count.Value ==1)

                {
                    Console.WriteLine("{0}-{1}", count.Key, count.Value);
                }
            }
           

        }
        public static SortedDictionary<Char, int> CharcountDictionary(string str)
        {
            SortedDictionary<Char, int> countDict = new SortedDictionary<char, int>();
            foreach (char item in str)
            {
                if(!(countDict.ContainsKey(
                    item)))
                {
                    countDict.Add(item
                        , 1);

                }
                else
                {
                    countDict[item]++;
                }
            }
            return countDict;

        }
    }
}
