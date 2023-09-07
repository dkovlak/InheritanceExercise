using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in comemon


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
            var bird1 = new Bird { Breed = "Parrot", Color = "green", Fly = true, Legs = 2, Name = "Jeremy", Size = 30, Sound = "Eat", Speak = true };
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Meet {bird1.Name}, the {bird1.Color} {bird1.Breed}!");
            Console.WriteLine($"- Size: {bird1.Size} cm");
            Console.WriteLine($"- Legs: {bird1.Legs}");
            Console.WriteLine($"- Can it fly? {(bird1.Fly ? "Sure!" : "No...")}");
            Console.WriteLine($"- Does it speak? {(bird1.Speak ? "Every Day" : "No...")}");
            Console.WriteLine($"- Sound it makes: '{bird1.Sound}'");
            Console.WriteLine("----------------------------------------------------");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
   
            var reptile = new Reptile
            {
                Breed = "Green iguana",
                Color = "Orange",
                Eats = true,
                Name = "Boba",
                PreferredTemperatureRange = 95,
                ScaleType = "small scales",
                Sound = "Hsss",
                Species = "Green iguana"
            };
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Meet your reptile friend!");
            Console.WriteLine("Name: " + reptile.Name);
            Console.WriteLine("Species: " + reptile.Species);
            Console.WriteLine("Breed: " + reptile.Breed);
            Console.WriteLine("Color: " + reptile.Color);
            Console.WriteLine("Scale Type: " + reptile.ScaleType);
            Console.WriteLine("Sound: " + reptile.Sound);
            Console.WriteLine("Preferred Temperature Range: " + reptile.PreferredTemperatureRange + " degrees Fahrenheit");
            Console.WriteLine("Eats: " + (reptile.Eats ? "Yes" : "No"));
            Console.WriteLine("\nHello, " + reptile.Name + "!");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
