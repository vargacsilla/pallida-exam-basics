using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static List<char> UniqueCharacters(string inputString)
        {
            var charList = new List<char>();
            try
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (charList.IndexOf(inputString[i]) == -1)
                    {
                        charList.Add(inputString[i]);
                    }
                    else
                    {
                        charList.RemoveAt(charList.IndexOf(inputString[i]));
                    }
                }
                return charList;
            }
            catch
            {
                return charList;
            }
        }
    }
}
