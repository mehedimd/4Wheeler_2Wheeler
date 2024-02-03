using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Wheeler_2Wheeler
{
    public enum VehicleType
    {
        TwoWheeler = 2,
        FourWheeler = 4
    }
    internal class Vehicle
    {
        public string ModelNo {  get; set; }
        public int MakeYear {  get; set; }
        public int NumOfSeat {  get; set; }
        public int NumOfGear {  get; set; }
        public double EngineCapacity {  get; set; }
        public VehicleType Type { get; set;}

    }
}
