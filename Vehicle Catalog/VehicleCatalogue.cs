using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Transactions;
using System.Xml.Serialization;

namespace Vehicle_Catalog
{
    class VehicleCatalogue
    {
        static void Main(string[] args)
        {
            List<Vehicles> vehicles = new List<Vehicles>();
          
            
            
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandElements = command.Split().ToArray();

                Vehicles vehicle = new Vehicles(commandElements[0]
                    , commandElements[1]
                    , commandElements[2]
                    , double.Parse(commandElements[3]));

                vehicles.Add(vehicle);

                command = Console.ReadLine();
            }
          
            
            
            string model = Console.ReadLine();
            while (model != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(x => x.Model == model).ToString());

                model = Console.ReadLine();
            }


            var cars = vehicles.FindAll(x => x.Type == "car");
            var carsHorsePower = cars.Sum(c => c.HorsePower);
            var carAveagePower = carsHorsePower / cars.Count;
            if (cars.Count == 0)
            {
                carAveagePower = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {carAveagePower:f2}.");


            var trucks = vehicles.FindAll(x => x.Type == "truck");
            var trucksHorsePower = trucks.Sum(c => c.HorsePower);
            var truksAveragePower = trucksHorsePower / trucks.Count;
            if (trucks.Count == 0)
            {
                truksAveragePower = 0;
            }
            Console.WriteLine($"Trucks have average horsepower of: {truksAveragePower:f2}.");

        }
    }
}
