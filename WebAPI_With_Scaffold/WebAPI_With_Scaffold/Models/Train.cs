using System;
using System.Collections.Generic;

namespace WebAPI_With_Scaffold.Models
{
    public partial class Train
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WaggonAnzahl { get; set; }
        public int Kmh { get; set; }
    }
}
