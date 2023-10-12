using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._4.Models
{
    internal class Bicylce : Vehicle
    {
        public string Type { get; set; }
        public Bicylce(string factoryName, string model, int driveTime, int drivePath, string type) : base(factoryName, model, driveTime, drivePath)
        {
            Type = type;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($@"Type: {Type}");
        }
    }
}
