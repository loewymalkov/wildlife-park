using System;
using System.Collections.Generic;

namespace Park
{
    public class Program
    {
        static void Main()
        {
          Console.WriteLine("What would you like to do? (Add/View/Remove");
          string input = Console.ReadLine();

          List<Animals> ViewAnimals = new List<Animals>(0);

          if (input.ToUpper() == "ADD")
          {
            string species = Console.ReadLine();
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string endangered = Console.ReadLine();

            
            Animals animal = new Animals(species, name, age, endangered);

            ViewAnimals.Add(animal);

            Main();
          }

          else if (input.ToUpper() == "VIEW") 
          {
            if (ViewAnimals.Count == 0)
            { 
              Console.WriteLine("\n Nothing matches your search criteria please don't be so picky");
              Main();
            }
            // display all the animals
            Main();
          }
          else if (input.ToUpper() == "REMOVE")
          {

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
