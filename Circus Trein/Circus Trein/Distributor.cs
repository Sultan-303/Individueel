using Circus_Trein;
using System;
using System.Collections.Generic;
using System.Linq;

public class Distributor
{
    private readonly List<Wagon> wagons = new List<Wagon>();

    public IList<Wagon> Wagons => wagons;

    public void DistributeAnimals(IEnumerable<Animal> animals)
    {
        var sortedAnimals = animals.OrderByDescending(a => (int)a.Size);

        foreach (var animal in sortedAnimals)
        {
            AddAnimalToWagon(animal);
        }
    }

    private void AddAnimalToWagon(Animal animal)
    {
        var suitableWagon = Wagons.FirstOrDefault(wagon => wagon.CanAddAnimal(animal));

        if (suitableWagon == null)
        {
            suitableWagon = new Wagon();
            wagons.Add(suitableWagon);
        }

        suitableWagon.TryAddAnimal(animal);
    }
}
