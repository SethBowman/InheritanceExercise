using System;
using System.Collections.Generic;

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
            var eagle = new Bird();
            eagle.Name = "Eagle";
            eagle.Age = 2;
            eagle.WingSpan = 12;
            eagle.CanFly = true;
            eagle.Diet = "carnivore";
            eagle.FeatherColor = "brown";
            eagle.IsPredator = true;
            eagle.IsNocturnal = false;

            Console.WriteLine($"Name: {eagle.Name}\nAge: {eagle.Age}\nWing Span: {eagle.WingSpan} inches\nCan Fly: {eagle.CanFly}\nDiet: {eagle.Diet}\nFeather Color: {eagle.FeatherColor}\nPredator: {eagle.IsPredator}\nNocturnal: {eagle.IsNocturnal}\n");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile();
            snake.Name = "Python";
            snake.Age = 1;
            snake.Location = "Jungle";
            snake.IsVenemous = true;
            snake.NumOfTeeth = 2;
            snake.CanRegen = false;
            snake.IsNocturnal = false;
            snake.Diet = "carnivore";

            Console.WriteLine($"Name: {snake.Name}\nAge: {snake.Age}\nLocation: {snake.Location}\nVenemous: {snake.IsVenemous}\nNumber of Teeth: {snake.NumOfTeeth}\nCan Regen: {snake.CanRegen}\nNocturnal: {snake.IsNocturnal}\nDiet: {snake.Diet}\n");

            var zoo = new List<Animal>();
            zoo.Add(snake);
            zoo.Add(eagle);

            foreach(var animal in zoo)
            {
                Console.WriteLine($"Name: {animal.Name}\n Age: {animal.Age}");
            }
        }
    }
}
