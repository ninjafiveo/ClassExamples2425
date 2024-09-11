using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples2425
{
    internal class Animal
    {   // The Zoo
        // What properties do we need?
        // Type of animal (Species), name, age, weight, height, region
        // Let's set the properties. Getters and Setters...
        public string AnimalSpecies { get; set; }
        public string AnimalName { get; set;}
        public int AnimalAge { get; set; }
        public double AnimalWeight { get; set;}
        public double AnimalHeight { get; set; }
        public int AnimalSpeed {  get; set; }
        public string AnimalRegion {  get; set; }

        // Constructor
        public Animal(string animalSpecies, string animalName, int animalAge, double animalWeight, double animalHeight, int animalSpeed, string animalRegions)
        {
            AnimalSpecies = animalSpecies;
            AnimalName = animalName;
            AnimalAge = animalAge;
            AnimalWeight = animalWeight;
            AnimalHeight = animalHeight;
            AnimalSpeed = animalSpeed;
            AnimalRegion = animalRegions;
        }

        // Method - Behaviour
        public void Run()
        {
            Console.WriteLine($"{AnimalName} the {AnimalSpecies} breaks free from the zoo and runs away at {AnimalSpeed} MPH.");
        }

        public void Roll()
        {

        }
    }
}
