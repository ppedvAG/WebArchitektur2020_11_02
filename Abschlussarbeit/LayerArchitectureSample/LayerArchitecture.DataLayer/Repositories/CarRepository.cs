using EFRepository;
using LayerArchitecture.DataLayer.Repositories.Contracts;
using LayerArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI_With_Scaffold.Data;

namespace LayerArchitecture.DataLayer.Repositories
{
    public class CarRepository : GenericRepository<Car, Guid>, ICarRepository
    {

        public CarRepository()
            :base(new CarDBV2Context())
        {

        }
    }
}
