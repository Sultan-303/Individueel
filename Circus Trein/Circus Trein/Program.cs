using Circus_Trein;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many animals need to be transported?");
        if (int.TryParse(Console.ReadLine(), out int amountOfAnimals))
        {
            var allAnimals = new List<Animal>();

            for (int i = 0; i < amountOfAnimals; i++)
            {
                Console.WriteLine($"Animal {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Size (S, M, or L): ");
                string sizeInput = Console.ReadLine();
                Size size = InputParser.ParseSize(sizeInput);

                Console.Write("Diet (H for herbivore, C for carnivore): ");
                string dietInput = Console.ReadLine();
                Diet diet = InputParser.ParseDiet(dietInput);

                Animal newAnimal = new Animal(name, diet, size);
                allAnimals.Add(newAnimal);
            }

            var distributor = new Distributor();
            distributor.DistributeAnimals(allAnimals);

            Console.WriteLine($"Number of wagons: {distributor.Wagons.Count}");
            for (int i = 0; i < distributor.Wagons.Count; i++)
            {
                var wagon = distributor.Wagons[i];
                Console.WriteLine($"Wagon {i + 1}:");
                foreach (var animal in wagon.Animals)
                {
                    Console.WriteLine($"  - {animal.Name} ({animal.Size}, {animal.Diet})");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}