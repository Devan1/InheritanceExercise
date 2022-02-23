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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var all_animals = new Animal()
            {
                consume = "consume food",
                breathe = "breathe",
                name = "name"
            };
            var reptile = new Reptile()
            {
                name = "Reptiles",
                legs = 4,
                cold_blooded = "cold blooded",
                scales = "have scales",
                lays_eggs = "lay eggs",
                type_heart = "three chambered hearts"
            };
            var bird = new Bird()
            {
                name = "Birds",
                legs = 2,
                has_feathers = "feathers",
                can_fly = "fly",
                has_wings = "have wings",
                has_beak = "beak",
                consume = "oxygen"
            };

            Console.WriteLine($"All animals {all_animals.consume}, {all_animals.breathe}, and have a {all_animals.name}.");
            Console.WriteLine($"However {reptile.name}, and {bird.name} have some distint traits.");
            Console.WriteLine($"For example {reptile.name} usually have {reptile.legs} legs, {reptile.lays_eggs}, and {reptile.scales}.");
            Console.WriteLine($"While birds also {reptile.lays_eggs} they only have {bird.legs} legs, can usually {bird.can_fly} and have {bird.has_beak}s. ");
        }
    }
}
