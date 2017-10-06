using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            var favouriteAnimals = new AnimalStorer();

            if (args.Length == 0)
            {
                Console.WriteLine("C# FavouriteAnimals - add your favourite in the following format: \"panda horse bear\"");
            }
            else
            {
                favouriteAnimals.AddAnimals(args);
            }
        }
    }
}
