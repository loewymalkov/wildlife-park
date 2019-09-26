using System;
using System.Collections.Generic;

namespace Park
{
    public class Program
    {
          public static List<string> ViewAnimals = new List<string>(0);
          // public static Dictionary<string, string> animalDictionary = new Dictionary<string, string>();
        static void Main()
        {
          Console.WriteLine("What would you like to do? (Add/View)");
          string input = Console.ReadLine();



          if (input.ToUpper() == "ADD")
          {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Species:");
            string species = Console.ReadLine();
            Console.WriteLine("Age:");
            string age = Console.ReadLine();
            Console.WriteLine("Conservation status:");
            string endangered = Console.ReadLine();

            
            Animals animal = new Animals(species, name, age, endangered);

            string animalInfo = "Name: " + animal.GetName() + "\nSpecies: " + animal.GetSpecies() + "\nAge: " + animal.GetAge() + "\nConservation status: " + animal.GetStatus();



            ViewAnimals.Add(animalInfo);

            Main();
          }

          else if (input.ToUpper() == "VIEW") 
          {
            if (ViewAnimals.Count == 0)
            { 
              Console.WriteLine("\n Nothing matches your search criteria please don't be so picky");
              Main();
            }
            
            foreach(string animal in ViewAnimals)
          {
            Console.WriteLine("-------------------------------");
            Console.WriteLine(animal);
          }
            Main();
          }
          else 
          {
            Console.WriteLine("There's a special place in Heaven for animal lovers, that's all I know. Figure it out.");

            Main();
          }
        }
    }
}
