using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public class Wagon
    {
        private readonly List<Animal> animals = new List<Animal>();

        public IEnumerable<Animal> Animals => animals;

        public int TotalPoints => Animals.Sum(a => (int)a.Size);

        public bool CanAddAnimal(Animal animal)
        {
            return TotalPoints + (int)animal.Size <= 10 && Animals.All(a => a.IsFriendlyWith(animal));
        }

        public bool TryAddAnimal(Animal animal)
        {
            if (CanAddAnimal(animal))
            {
                animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}
