using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    //Capitalize the First and last character of each word of string
    class Program11
    {
        static void Main()
        {
            string input = "hello world";
            string output = CapitalizeFirstAndLast(input);
            Console.WriteLine(output);

        }
        static string CapitalizeFirstAndLast(string str)
        {
            string[] words = str.Split(' ');
            for(int i=0;i<words.Length;i++)
            {
                string word = words[i];
                if(word.Length>1)
                {
                    char firstChar = char.ToUpper(word[0]);
                    char lastchar = char.ToUpper(word[word.Length - 1]);
                    string middle = word.Substring(1, word.Length - 2);
                    words[i] = firstChar +middle+ lastchar;
                }
                else if(word.Length==1)
                {
                    words[i] = char.ToUpper(word[0]).ToString();
                }
            }
            return string.Join(" ", words);
        }

    }
}
