using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Solid.InterfaceSegregation.Models
{
    public class Laptop : IProduct
    {
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }
        public double InchesScreen { get; set; }
        public double Weight { get; set; }
        public string OperatingSystem { get; set; }
        public int Ram { get; set; }
        public string Processor { get; set; }
        public bool WithAnthena { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
