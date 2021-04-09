using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Solid.InterfaceSegregation.Models
{
    public class TV : IProduct, IAnalogComunicationDevices
    {
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double InchesScreen { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public bool WithAnthena { get; set; }
    }
}
