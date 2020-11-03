using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVCOverview.Models
{
    public interface ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ConstructYear { get; set; }

        public string Farbe { get; set; }

    }
}
