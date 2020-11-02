using System;

namespace Part5_DependencyInjections
{
    class Program
    {
        static void Main(string[] args)
        {
            BadCarService badService = new BadCarService();
            badService.RepairBadCar(new BadCar());


            ICarService goodService = new CarService();



            ICar car = new Car();
            car.Marke = "Porsche";
            car.Type = "911";
            car.Baujahr = DateTime.Now;

            goodService.RepairCar(car);

            goodService.RepairCar(new Car { Marke = "Daimler", Type = "Silberfeil", Baujahr = DateTime.Now });

            goodService.RepairCar(new MockCar());
        }
    }

    #region BadCode


    // BadCar ist in der SharedLibrary.dll implementiert
    //Implementierungzeit 8Tage 
    public class BadCar
    {
        public string Marke { get; set; }
        public string Type { get; set; }
        public DateTime Baujahr { get; set; }
    }


    //BadCarService ist in der Service.dll implementiert. 
    //BadCarService benltigt für das implementieren 4Tage
    public class BadCarService
    {
        //feste Kopplung -> BadCarSerive benötigt immer eine Definition bzw. Reference (bei Lib) von BadCar
        public void RepairBadCar(BadCar car)
        {

        }
    }
    #endregion


    #region Good Code

    //SharedLibrary.Contracts.dll
    public interface ICar
    {
        string Marke { get; set; }
        string Type { get; set; }
        DateTime Baujahr { get; set; }
    }


    //SharedLibrary.dll
    public class Car : ICar
    {
        public string Marke { get; set; }
        public string Type { get; set; }
        public DateTime Baujahr { get; set; }
    }


    public interface ICarService
    {
        void RepairCar(ICar car);
    }

    //Service.dll 
    public class CarService : ICarService
    {
        public void RepairCar(ICar car) //enötigt nur die SharedLibrary.Contracts.dll
        {
            //Repariere Auto
        }
    }


    public class MockCar : ICar
    {
        public string Marke { get; set; } = "BMW";
        public string Type { get; set; } = "Z8";
        public DateTime Baujahr { get; set; } = new DateTime(1998, 3, 3);
    }
    #endregion
}
