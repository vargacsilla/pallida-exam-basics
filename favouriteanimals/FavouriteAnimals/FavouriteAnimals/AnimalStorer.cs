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
        List<string> animals;
        string path = @"../../favourites.txt";

        public void AddAnimal(string inputAnimal)
        {
            if (animals.Contains(inputAnimal))
            {
                return;
            }
            else
            {
                animals.Add(inputAnimal);
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine(inputAnimal);
                }
            }
        }
    }
}
