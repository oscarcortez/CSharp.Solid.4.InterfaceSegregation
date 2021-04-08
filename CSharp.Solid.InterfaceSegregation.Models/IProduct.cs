using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Solid.InterfaceSegregation.Models
{
    interface IProduct
    {
        decimal Price { get; set; }
        int Stock { get; set; }
        double InchesScreen { get; set; }
        double Weight { get; set; }
        string OperatingSystem { get; set; }
        string Color { get; set; }
        int Ram { get; set; }
        string Processor { get; set; }
    }
}
