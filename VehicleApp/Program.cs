using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace VehicleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Increase speed to: ");

            double speedAmount = Convert.ToDouble(Console.ReadLine());

            Car car = new Car("Porsche", 100.2, speedAmount, "Car", "Green", 256, 10);

            Truck truck = new Truck("Volvo", 81, speedAmount, "Truck", "Black", 210, 20000);



            Console.WriteLine($"| CAR | \n{car.ToDisplay()}");
            Console.WriteLine();
            Console.WriteLine($"| TRUCK |  \n{truck.ToDisplay()}");
   





            Console.ReadKey();
        }
    }
}
