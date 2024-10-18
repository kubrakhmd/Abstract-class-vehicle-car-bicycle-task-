using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class Vehicle
    {


        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        public double AverageSpeed()
        {
            if (DriveTime > 0)
                return DrivePath / DriveTime;
            else
                return 0;
        }

        public virtual string GetInfo()
        {
            return $"Factory: {FactoryName}, Model: {Model}, Color: {Color}, Drive Time: {DriveTime} hours, Drive Path: {DrivePath} km";
        }

        public override string ToString()
        {
            return $"{FactoryName} {Model}";
        }

        public abstract string DefineNatureHarmness();



    }
    }

