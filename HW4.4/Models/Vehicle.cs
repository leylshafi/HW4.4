using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._4.Models
{
    internal abstract class Vehicle
    {
        protected Vehicle(string factoryName, string model, int driveTime, int drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            DriveTime = driveTime;
            DrivePath = drivePath;
            ProductionDate = DateTime.UtcNow;
        }

        public string FactoryName { get; set; }
        public string Model { get; set; }
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }

        public DateTime ProductionDate { get; }


        public int AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($@"Factory name: {FactoryName},
Model: {Model},
DriveTime: {DriveTime},
DrivePath: {DrivePath}km,
Production Date: {ProductionDate}");
        }

        public override string ToString()
        {
            return $@"Factory name: {FactoryName},
Model: {Model}";
        }

        public abstract void DefineNatureHarmness();

    }
}
