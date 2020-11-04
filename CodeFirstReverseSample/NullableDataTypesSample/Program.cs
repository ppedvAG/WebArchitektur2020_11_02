using System;

namespace NullableDataTypesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue; //beinhaltet den Wert 0

            bool boolValue; //beinhaltet den Wert false


            int? nullableValue = null;
            bool? nullableBoolean = null;

            if (nullableValue.HasValue)
                Console.WriteLine($"{nullableValue.Value}");

            if (nullableBoolean.HasValue)
                Console.WriteLine($"{nullableBoolean.Value}");

            //Console.WriteLine($"Integer Wert (default){intValue} ");

            //Console.WriteLine($"Bool Wert (default){boolValue} ");


            

            //int? weightOfCargo = TryGetTruckCargoWeight()
            //if (weightOfCargo.HasValue)
            // -> 
        }
    }
}
