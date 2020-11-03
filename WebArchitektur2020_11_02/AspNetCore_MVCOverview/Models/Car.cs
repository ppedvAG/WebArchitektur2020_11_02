using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVCOverview.Models
{
    public class Car : ICar
    {
        public string Brand { get; set; } = "Porsche";
        public string Model { get; set; } = "911";
        public DateTime ConstructYear { get; set; } = DateTime.Now;
        public string Farbe { get; set; } = "Schwarz";
    }
}
