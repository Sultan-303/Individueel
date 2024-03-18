using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Diet
{
    Carnivore,
    Herbivore
}

public enum Size
{
    Small = 1,
    Medium = 3,
    Large = 5
}

public class Animal
{
    public string Name { get; }
    public Diet Diet { get; }
    public Size Size { get; }

    public Animal(string name, Diet diet, Size size)
    {
        Name = name;
        Diet = diet;
        Size = size;
    }

    public static Animal SmallHerbivore => new("Small Herbivore", Diet.Herbivore, Size.Small);
    public static Animal MediumHerbivore => new("Medium Herbivore", Diet.Herbivore, Size.Medium);
    public static Animal LargeHerbivore => new("Large Herbivore", Diet.Herbivore, Size.Large);
    public static Animal SmallCarnivore => new("Small Carnivore", Diet.Carnivore, Size.Small);
    public static Animal MediumCarnivore => new("Medium Carnivore", Diet.Carnivore, Size.Medium);
    public static Animal LargeCarnivore => new("Large Carnivore", Diet.Carnivore, Size.Large);

    public bool IsFriendlyWith(Animal otherAnimal)
    {
        if (Diet == Diet.Carnivore && (otherAnimal.Diet == Diet.Carnivore || otherAnimal.Size <= Size))
            return false;

        return true;
    }
}
