using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTU_ZooManagementSystem
{
    public class Zoo
    {
        private List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void FeedAnimals(FoodType foodType)
        {
            foreach (var animal in animals)
            {
                try
                {
                    animal.Eat(foodType);
                }
                catch (InvalidFeedingException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public void MoveAnimals(HabitatType habitatType)
        {
            foreach (var animal in animals)
            {
                try
                {
                    animal.Move(habitatType);
                }
                catch (MovementFailedException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public void SpeakToAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} says '{animal.Speak()}'");
            }
        }
    }
}