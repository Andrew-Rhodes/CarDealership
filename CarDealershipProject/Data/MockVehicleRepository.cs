using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public class MockVehicleRepository : IVehicleRepository
    {
        public static List<Vehicle> _vehicles = new List<Vehicle>();

        public MockVehicleRepository()
        {
            if (!_vehicles.Any())
            {
                _vehicles.AddRange(new List<Vehicle>()
                {
                    new Vehicle()
                    {
                        VehicleId = 1,
                        Make = "Ford",
                        Model = "Sedan",
                        Year = 1932,
                        Milage = 56792,
                        Price = 25692,
                        Trade = 1
                    },
                    new Vehicle()
                    {
                        VehicleId = 2,
                        Make = "Dodge",
                        Model = "Dart",
                        Year = 1966,
                        Milage = 123456,
                        Price = 10900,
                        Trade = 1
                    },
                    new Vehicle()
                    {
                        VehicleId = 3,
                        Make = "Chevy",
                        Model = "Other",
                        Year = 1957,
                        Milage = 99999,
                        Price = 78520,
                        Trade = 0
                    },
                    new Vehicle()
                    {
                        VehicleId = 4,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1962,
                        Milage = 0,
                        Price = 330000,
                        Trade = 1
                    },
                    new Vehicle()
                    {
                        VehicleId = 5,
                        Make = "GMC",
                        Model = "TRUCK",
                        Year = 1949,
                        Milage = 666,
                        Price = 666666,
                        Trade = 0
                    }

                });
            }
        }


        public List<Vehicle> GetAll()
        {
            return _vehicles;
        }

        public List<Vehicle> GetTrades()
        {
            List<Vehicle> Trades = new List<Vehicle>();

            foreach (var vehicle in _vehicles)
            {
                if (vehicle.Trade == 1)
                {
                    Trades.Add(vehicle);
                }
            }

            return Trades;
        }

        public List<Vehicle> GetSale()
        {
            List<Vehicle> Sale = new List<Vehicle>();

            foreach (var vehicle in _vehicles)
            {
                if (vehicle.Trade == 0)
                {
                    Sale.Add(vehicle);
                }
            }

            return Sale;
        }
    }
}
