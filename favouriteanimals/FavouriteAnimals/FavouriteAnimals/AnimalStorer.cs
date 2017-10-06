using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class AnimalStorer
    {
        string path = @"../../favourites.txt";
        List<string> animals;

        public void AddAnimals(string[] inputAnimals)
        {
            animals = File.ReadAllLines(path).ToList<string>();
            foreach (var newAnimal in inputAnimals)
            {
                if (animals.Contains(newAnimal))
                {
                    return;
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(path))
                    {
                        writer.WriteLine(newAnimal);
                    }
                }
            }
        }
    }
}
