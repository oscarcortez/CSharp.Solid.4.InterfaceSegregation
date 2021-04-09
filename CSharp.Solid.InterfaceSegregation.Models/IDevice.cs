using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Solid.InterfaceSegregation.Models
{
    interface IDevice
    {
        double InchesScreen { get; set; }
        string OperatingSystem { get; set; }
        string Color { get; set; }
        int Ram { get; set; }
        string Processor { get; set; }

    }
}
