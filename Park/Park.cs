using System;
using System.Collections.Generic;
namespace Park
{
  class Animals 
    {
      private string _species;
      private string _name;
      private int _age;
      private string _endangered;

      public int AnimalCount;

      public Animals(string species, string name, int age, string endangered)
      {
        _species = species;
        _name = name;
        _age = age;
        _endangered = endangered;
      }

      public string GetSpecies()
      {
        return _species;
      }

      public string GetName()
      {
        return _name;
      }
      public int GetAge()
      {
        return _age;
      }
      public string GetStatus()
      {
        return _endangered;
      }
    }






}