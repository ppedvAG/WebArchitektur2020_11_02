using System;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }



    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstance = 0;

        private Singleton()
        {
            numberOfInstance++;
            Console.WriteLine($"Number of instances = {numberOfInstance}");
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }

    public sealed class Singleton1
    {
        private static Singleton1 instance;
        private Singleton1() { }
        public static Singleton1 Instance
        {
            get
            {
                //Achtung bei Multi-Threading 
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
    }




    //Lösung, wenn Threading im Einsatz kommt
    public sealed class Singleton2
    {
        //We are using volatile to ensure that
        //assignment to the instance variable finishes before it’s
        //access.
        private static volatile Singleton2 instance;
        private static object lockObject = new Object();
        private Singleton2() { }
        public static Singleton2 Instance
        {
            get
            {
                if (instance == null)
                {
                    //
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new Singleton2();
                    }
                }
                return instance;
            }
        }
    }
}
