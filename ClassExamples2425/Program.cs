using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples2425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat1 = new Animal("Feline", "Beelzebub", 1032, 120, 1.5, 25, "The Underworld");
            Animal doggo1 = new Animal("God's Gift to Humans", "St. Mozzy", 5, 14, 1.5, 299, "The Promise Land");

            Console.WriteLine(doggo1.AnimalName + " vs. " + cat1.AnimalName);
            doggo1.Run();
            cat1.Run();

            Console.ReadKey();
        }
    }
}
