using Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppWithDependencyInjection.Contracts
{
    public interface ICarService
    {
        void Repair(ICar car);
    }
}
