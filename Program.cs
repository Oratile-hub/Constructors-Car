using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mercedis Benz", "Mate Black", 2023);

            Console.WriteLine(car1.model);
            Console.WriteLine(car1.colour);
            Console.WriteLine(car1.year);
            Console.ReadLine();
        }
    }
}
