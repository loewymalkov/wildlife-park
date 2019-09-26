using System;
using System.Collections.Generic;
namespace Park
{
  class Animals 
    {
      private string _species;
      private string _name;
      private string _age;
      private string _endangered;


      public Animals(string species, string name, string age, string endangered)
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
      public string GetAge()
      {
        return _age;
      }
      public string GetStatus()
      {
        return _endangered;
      }
    }






}