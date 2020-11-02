using System;

namespace Entities.Contracts
{
    public interface ICar
    {
        string Marke { get; set; }
        string Type { get; set; }
        DateTime Baujahr { get; set; }
    }


}
