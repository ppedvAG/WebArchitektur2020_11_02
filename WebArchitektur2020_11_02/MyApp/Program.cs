using AppWithDependencyInjection;
using AppWithDependencyInjection.Contracts;
using Entities;
using Entities.Contracts;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Car();
            ICarService service = new CarService();
            service.Repair(car);
        }
    }
}
