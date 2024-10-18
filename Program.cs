namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


       
          
           
                Vehicle[] vehicles = new Vehicle[]
                {
            new Car
            {
                FactoryName = "Toyota",
                Model = "Camry",
                Color = "Blue",
                DriveTime = 2,
                DrivePath = 120,
                DoorCount = 4,
                IsElectricCar = false
            },
            new Car
            {
                FactoryName = "Tesla",
                Model = "Model S",
                Color = "Red",
                DriveTime = 1.5,
                DrivePath = 90,
                DoorCount = 4,
                IsElectricCar = true
            },
            new Bicycle
            {
                FactoryName = "Giant",
                Model = "Defy",
                Color = "Black",
                DriveTime = 0.5,
                DrivePath = 15,
                Type = "Road"
            },
            new Bicycle
            {
                FactoryName = "Trek",
                Model = "Marlin 5",
                Color = "Green",
                DriveTime = 1,
                DrivePath = 10,
                Type = "Mountain"
            }
                };

                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle.GetInfo());
                    Console.WriteLine($"Average Speed: {vehicle.AverageSpeed()} km/h");
                    Console.WriteLine($"Nature Harmness: {vehicle.DefineNatureHarmness()}");
                    Console.WriteLine(vehicle.ToString());
                    Console.WriteLine();
                }
            }
        }

    }

