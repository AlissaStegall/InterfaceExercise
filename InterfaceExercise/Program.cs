using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE

            //Create 3 classes called Car , Truck , & SUV DONE

            //In your IVehicle DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes DONE

            /*Create 2 members that are specific to each class DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values DONE

            var car = new Car();

            car.HasTrunk = true;
            car.InDrive = false;
            car.InReverse = true;
            car.IsHatchback = true;
            car.Logo = "bold plus sign";
            car.CompanyName = "Chevy";
            car.Make = "Chevy";
            car.Model = "Nova";
            car.Year = 1974;

            var truck = new Truck();

            truck.CompanyName = "Dodge";
            truck.InDrive = true;
            truck.InReverse = false;
            truck.Is4WheelDrive = true;
            truck.Logo = "Rams head";
            truck.Make = "Dodge";
            truck.Model = "Ram";
            truck.Year = 2001;
            truck.TowCapacity = 2245;

            var suv = new SUV();

            suv.CompanyName = "Honda";
            suv.InDrive = true;
            suv.InReverse = false;
            suv.Logo = "encased \"H\"";
            suv.Make = "Honda";
            suv.Model = "Pilot";
            suv.Year = 2015;
            suv.NumberOfSeats = 5;
            suv.ThirdRowSeating = false;

            var vehicles = new List<IVehicle>() { car, truck, suv};

            foreach(var vehicle in vehicles)
            {
                vehicle.HonkNoise();
                Console.WriteLine($"Make: {vehicle.Make}, " +
                    $"\nModel: {vehicle.Model}," +
                    $"\nYear: {vehicle.Year}");
                Console.WriteLine("");
                Console.WriteLine($"Is in Drive: {vehicle.InDrive}");
                Console.WriteLine($"Is in Reverse: {vehicle.InReverse}");
                Console.WriteLine("");
            }

            var items = new List<ICompany>() { car, truck, suv };

            foreach(var item in items)
            {
                Console.WriteLine($"Company Name: {item.CompanyName}" +
                    $" \nLogo: {item.Logo}");
                Console.WriteLine("");
            }
        }
    }
}
