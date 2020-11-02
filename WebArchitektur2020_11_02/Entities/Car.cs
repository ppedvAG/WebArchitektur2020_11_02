using Entities.Contracts;
using System;

namespace Entities
{
    public class Car : ICar
    {
        public string Marke { get; set; }
        public string Type { get; set; }
        public DateTime Baujahr { get; set; }
    }
}
