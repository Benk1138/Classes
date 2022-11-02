using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        var car1 = new Car();
        car1. Year = 2016;
            car1. Make = "Mercedes";
            car1. Model = "C300"
            car1. EngineNoise = "Good";
            car1. HonkNoise = "Beep Beep";
            car1. IsDriavable = true;

            var car2 = new Car() { Year = 2017, Make = "Toyota", Model = "Corolla", EngineNoise = "quiet", HonkNoise = "Beep Beep", IsDriaveable = True };



        var car3 = new Car(2020, "Honda", "Civic", "Vroom", "Loud Honk", true);
    } 
}

