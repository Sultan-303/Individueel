using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public class InputParser
    {
        const Size defaultSize = Size.Medium;
        const Diet defaultDiet = Diet.Herbivore;

        public static Size ParseSize(string sizeInput)
        {
            switch (sizeInput.ToLower())
            {
                case "s":
                    return Size.Small;
                case "m":
                    return Size.Medium;
                case "l":
                    return Size.Large;
                default:
                    Console.WriteLine("Invalid size input. Default value Medium will be used.");
                    return defaultSize;
            }
        }

        public static Diet ParseDiet(string dietInput)
        {
            switch (dietInput.ToLower())
            {
                case "h":
                    return Diet.Herbivore;
                case "c":
                    return Diet.Carnivore;
                default:
                    Console.WriteLine("Invalid diet input. Default value Herbivore will be used.");
                    return defaultDiet;
            }
        }
    }
}
