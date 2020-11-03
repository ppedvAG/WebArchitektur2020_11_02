using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
    public interface IAnimal
    {
        void Speak();
        void Action();
    }

    public class Cat : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Walk on tree");
        }

        public void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("hunting the postman");
        }

        public void Speak()
        {
            Console.WriteLine("Wuff Wuff");
        }
    }

    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }

    public class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }

    public class CatFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }

}
