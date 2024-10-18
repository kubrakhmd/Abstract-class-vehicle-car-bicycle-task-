using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    
    
        internal class Car : Vehicle
        {
            public int DoorCount { get; set; }
            public bool IsElectricCar { get; set; }

            public override string GetInfo()
            {
                return base.GetInfo() + $", Door Count: {DoorCount}, Electric Car: {IsElectricCar}";
            }

            public override string DefineNatureHarmness()
            {
                return IsElectricCar ? "low" : "high";
            }
        }

 }

