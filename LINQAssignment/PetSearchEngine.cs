using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    internal class PetSearchEngine
    {
        private List<Pet> _pets;
        public PetSearchEngine(List<Pet> pets)
        {
            _pets = pets;
        }
        public Pet? GetPetByName(string name)
        {
            return _pets.FirstOrDefault(pet => pet.Name == name, null);
        }
        public List<Pet> GetPetsBySound(string sound)
        {
            return _pets.Where(pet => pet.Sound == sound).ToList();
        }
        public List<string> GetFoodsByPetType(string type)
        {
            return _pets.Where(pet => pet.Type == type).OrderBy(pet => pet.Food).Select(pet => pet.Food).ToList();
        }
        public List<Pet> GetPetsByFeature(string feature)
        {
            return _pets.Where(pet => pet.Features.Contains(feature)).ToList();
        }
        public void DisplayEnclosures()
        {
            var enclosureCollection = from pet in _pets
                                      group new { pet.Name, pet.Type }
                                      by pet.Enclosure into enclosures
                                      orderby enclosures.Key
                                      select enclosures;
            Console.WriteLine("Enclosures:");
            foreach (var enclosure in enclosureCollection)
            {
                Console.WriteLine($"in the {enclosure.Key} there are {enclosure.Count()} pets:");
                var pets = enclosure.ToList();
                foreach (var pet in pets)
                {
                    Console.WriteLine($"{pet.Name} the {pet.Type}");
                }
            }
        }
    }
}
