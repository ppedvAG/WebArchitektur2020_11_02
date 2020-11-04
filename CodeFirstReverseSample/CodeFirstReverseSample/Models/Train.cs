using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstReverseSample.Models
{
    public class Train
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int WaggonAnzahl { get; set; }
        public int KMH { get; set; }
    }
}
