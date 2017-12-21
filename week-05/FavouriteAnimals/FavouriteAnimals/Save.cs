using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FavouriteAnimals
{
    class Save
    {
        public void SaveToTextFile(string[] addAnimal)
        {
            string path = @"D:\greenfox\arvaianett\week-05\FavouriteAnimals\animals.txt";

            string[] animalsArray = File.ReadAllLines(path);
        
            Dictionary<string, int> animalDictionary = new Dictionary<string, int>();

            for (int i = 0; i < animalsArray.Length; i++)
            {                              
                if (!animalDictionary.ContainsKey(animalsArray[i]))
                {
                    animalDictionary.Add(animalsArray[i], i);
                }
                else
                {
                    int count = 0;
                    animalDictionary.TryGetValue(animalsArray[i], out count);
                    animalDictionary.Remove(animalsArray[i]);
                    animalDictionary.Add(animalsArray[i], count + 1);
                }
            }
            for (int i = 0; i < addAnimal.Length; i++)
            {
                if (!animalDictionary.ContainsKey(addAnimal[i]))
                {
                    animalDictionary.Add(addAnimal[i], i);

                    string animal = addAnimal[i].ToString();

                    AppendAnimals(animal);
                }
                else
                {
                    int count = 0;
                    animalDictionary.TryGetValue(addAnimal[i], out count);
                    animalDictionary.Remove(addAnimal[i]);
                    animalDictionary.Add(addAnimal[i], count + 1);
                }
            }
        }

        public void AppendAnimals(string animal)
        {
            string path = @"D:\greenfox\arvaianett\week-05\FavouriteAnimals\animals.txt";

            StreamWriter appendAnimalToFile = new StreamWriter(path,true);

            appendAnimalToFile.WriteLine(animal);

            appendAnimalToFile.Close();
        }
    }
}
