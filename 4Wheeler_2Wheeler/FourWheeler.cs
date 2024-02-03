using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Wheeler_2Wheeler
{
    internal class FourWheeler : Vehicle, IInterior
    {
        public int NumOfDoor {  get; set; }

        public void InteriorDesign(Car c)
        {
            Console.WriteLine("===================== Car Detail's ========================");
            Console.WriteLine($"ModelNo: {c.ModelNo}, MakeYear: {c.MakeYear}, NumOfGear: {c.NumOfGear}, " +
                $"NumOfSeat: {c.NumOfSeat}, Capacity: {c.EngineCapacity}, Type: {c.Type}, NumOfDoor: {c.NumOfDoor}");
        }
    }
}
