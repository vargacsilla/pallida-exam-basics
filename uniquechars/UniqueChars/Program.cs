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

        private static List<char> UniqueCharacters(string inputString)
        {
            var charList = new List<char>();
            foreach (var letter in inputString)
            {
                try
                {
                    int existingIndex = charList.IndexOf(letter);
                    charList.RemoveAt(existingIndex);
                }
                catch
                {
                    charList.Add(letter);
                }
            }
            return charList;
        }
    }
}
