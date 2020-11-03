using System;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory catFactory = new CatFactory();
            IAnimal cat =  catFactory.CreateAnimal();
            cat.Speak(); 
            cat.Action();




            Console.ReadKey();
        }
    }
}
