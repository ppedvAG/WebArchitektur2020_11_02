using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstSample.Models
{
    //Bis EF Core 3.1 muss eine Tabelle in Code First immer eine ID aufweisen
    public class Car
    {
        public Guid Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string ConstructYear { get; set; }

        public string Farbe { get; set; }

        public bool MitRadio { get; set; }
        public bool IsCaprio { get; set; }
    }
}
