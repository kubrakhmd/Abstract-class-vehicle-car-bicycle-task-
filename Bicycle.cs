using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Bicycle: Vehicle
    {
        
        
            public string Type { get; set; } 

            public override string GetInfo()
            {
                return base.GetInfo() + $", Type: {Type}";
            }

            public override string DefineNatureHarmness()
            {
                return "none" ;
            }
        }

    }






