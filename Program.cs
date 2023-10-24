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

        static void Task3()

        {
            Quaternion q1 = new Quaternion(1.0, 2.0, 3.0, 4.0);
            Quaternion q2 = new Quaternion(2.0, 3.0, 4.0, 5.0);

            Quaternion sum = q1 + q2;
            Quaternion difference = q1 - q2;
            Quaternion product = q1 * q2;
            double norm = q1.Norm();
            Quaternion conjugate = q1.Conjugate();
            Quaternion inverse = q1.Inverse();
            bool areEqual = (q1 == q2);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Norm of q1: " + norm);
            Console.WriteLine("Conjugate of q1: " + conjugate);
            Console.WriteLine("Inverse of q1: " + inverse);
            Console.WriteLine("Are q1 and q2 equal? " + areEqual);

            double[,] rotationMatrix = q1.ToRotationMatrix();
            Console.WriteLine("Rotation Matrix of q1:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(rotationMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
            //Task4();

            // delay to read from screen
            Console.WriteLine("Press any key to finnish this program...");
            Console.Read();
        }
    }
}


