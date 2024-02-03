using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Wheeler_2Wheeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car()
            {
                ModelNo = "C1",
                MakeYear = 2015,
                EngineCapacity = 5,
                NumOfDoor = 4,
                NumOfGear = 7,
                NumOfSeat = 8,
                Type = VehicleType.FourWheeler

            };
            c1.InteriorDesign(c1);
            Console.WriteLine(c1.Type);


            Console.ReadKey();
        }
    }
}
