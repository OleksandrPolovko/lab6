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
        static void Main(string[] args)
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
    }
}
