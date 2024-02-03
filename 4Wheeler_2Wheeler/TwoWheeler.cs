using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Wheeler_2Wheeler
{
    internal class TwoWheeler : Vehicle, IExterior
    {
        public double BPH {  get; set; }
        public double EMPL {  get; set; }
        public double NM {  get; set; }
        public string FrontBreak {  get; set; }
        public string RearBreak {  get; set; }
        public string Cooling {  get; set; }
        public void ExteriorDesign(Motorcycle m)
        {
            Console.WriteLine("===================== Motorcycle Detail's ========================");
            Console.WriteLine($"ModelNo: {m.ModelNo}, MakeYear: {m.MakeYear}, NumOfGear: {m.NumOfGear}, " +
                $"NumOfSeat: {m.NumOfSeat}, Capacity: {m.EngineCapacity}, Type: {m.Type}, Maximum Power: " +
                $"{m.BPH}, Max Torque: {m.NM}, Milege: {m.EMPL}, Cooling: {m.Cooling}");

        }
    }
}
