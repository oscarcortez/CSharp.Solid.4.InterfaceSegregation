using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Solid.InterfaceSegregation.Models
{
    public class TV : IProduct
    {
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double InchesScreen { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public string OperatingSystem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Ram { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Processor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool WithAnthena { get; set; }
    }
}
