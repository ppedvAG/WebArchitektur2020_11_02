using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_With_Scaffold.Models;

namespace WebAPI_With_Scaffold.Data
{
    public static class DataSeed
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (CarDBV2Context ctx = new CarDBV2Context(serviceProvider.GetRequiredService<DbContextOptions<CarDBV2Context>>()))
            {
                if (!ctx.Car.Any())
                {
                    ctx.Car.Add(new Car { Id = Guid.NewGuid(), Brand = "Daimler", Model = "Batmobil", ConstructYear = DateTime.Now.Year.ToString(), Farbe = "schwarz", IsCaprio = false, MitRadio = true });
                    ctx.Car.Add(new Car { Id = Guid.NewGuid(), Brand = "Porsche", Model = "Batmobil", ConstructYear = DateTime.Now.Year.ToString(), Farbe = "schwarz", IsCaprio = false, MitRadio = true });

                    ctx.Car.Add(new Car { Id = Guid.NewGuid(), Brand = "Ferrari", Model = "F211", ConstructYear = DateTime.Now.Year.ToString(), Farbe = "rot", IsCaprio = false, MitRadio = true });
                    ctx.Car.Add(new Car { Id = Guid.NewGuid(), Brand = "Aston Martin", Model = "BondAuto", ConstructYear = DateTime.Now.Year.ToString(), Farbe = "schwarz", IsCaprio = false, MitRadio = true });
                    ctx.Car.Add(new Car { Id = Guid.NewGuid(), Brand = "Maybach", Model = "Papamobil", ConstructYear = DateTime.Now.Year.ToString(), Farbe = "lila", IsCaprio = false, MitRadio = true });

                    ctx.SaveChanges();
                }
            }
        }
    }
}
