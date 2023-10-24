using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab6.Vehicle;

namespace Lab6
{
    internal class Program
    {
        static void Task1()
        {
            TransportNetwork network = new TransportNetwork();

            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();

            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);

            network.ControlMovement();

            Route route = new Route("City A", "City B");
            string optimalRoute = network.CalculateOptimalRoute(route, car);
            Console.WriteLine(optimalRoute);

            // Додайте логіку посадки та висадки пасажирів тут

            Console.ReadKey();
        }

            static void Task2()

        {
            MathOperations math = new MathOperations();

            int sum = math.Add(8, 5);
            int diff = math.Subtract(10, 4);
            int product = math.Multiply(5, 5);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + diff);
            Console.WriteLine("Product: " + product);

            Console.ReadKey();
        }
        static void Main (string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();

            // delay to read from screen
            Console.WriteLine("Press any key to finnish this program...");
            Console.Read();
        }
    }
}

