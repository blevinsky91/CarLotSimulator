using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLot carLotInstance = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            Car car1 = new Car();
            car1.Make = "Honda";
            car1.Model = "Accord";
            car1.Year = 2023;
            car1.EngineNoise = "purrr";
            car1.HonkNoise = "honk honk";
            car1.IsDriveable = true;

            Car car2 = new Car();
            car2.Make = "Ferrari";
            car2.Model = "F50";
            car2.Year = 1995;
            car2.EngineNoise = "vroom vroom";
            car2.HonkNoise = "beep beep";
            car2.IsDriveable = true;

            Car car3 = new Car() { Make = "Porshe", Model = "911 Turbo", Year = 2013, EngineNoise = "wommm", HonkNoise = "chirp chirp", IsDriveable = false };


            //Call each of the methods for each car

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.HonkNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Dot
            car1.Convertible = false;

            //Object Initializer
            Car car4 = new Car() { Convertible = true };

            //Custom
            //Car car5 = new Car("Prius", "Black");



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLotInstance.ListOfCars.Add(car1);
            carLotInstance.ListOfCars.Add(car2);
            carLotInstance.ListOfCars.Add(car3);

            foreach (var item in carLotInstance.ListOfCars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
