using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI_With_Scaffold.Data;

namespace LayerArchitecture.DataLayer.EFContext.Factory
{
    public class CarDBContextFactory
    {
        private CarDBV2Context _context;

        static CarDBContextFactory()
        {

        }


        public CarDBV2Context ContextInstance
        {
            get
            {
                if (_context == null)
                    _context = new CarDBV2Context();


                return _context;
            }
        }

        public void Refresh()
        {
            _context = new CarDBV2Context();
        }

    }
}
