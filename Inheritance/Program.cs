using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            Console.WriteLine();

            var bird = new Animal();

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var penguin = new Bird()
            {
                CanFly = false,
                IsSmall =  false,
                IsScavenger = false,
                Migrates = false,
                HowManyEyes = 2,
                HowManyLegs = 2,
                CanMove = true,
                LaysEggs = true
            };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var lizard = new Reptile();
            lizard.HasScales = true;
            lizard.CanRegenerateTail = true;
            lizard.IsColdBlooded = true;
            lizard.IsAPredator = false;
            lizard.CanMove = true;
            lizard.HowManyEyes = 2;
            lizard.HowManyLegs = 4;
            lizard.CanMove = true;
            lizard.LaysEggs = true;
        }
    }
}
