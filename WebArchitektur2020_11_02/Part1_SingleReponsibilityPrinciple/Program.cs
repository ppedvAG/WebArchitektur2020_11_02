using System;

namespace Part1_SingleReponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region Bad Sample

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool InsertInEmployeeTable(Employee em)
        {
            //Speichere in die Datenbank

            return true;
        }

        public void GenerateReport (Employee em) // Eine Klasse hat ein Aufgabengebiet 
        {
            //Report wird generiert.
        }
    }
    #endregion

    #region Better Variante
    //Gliedere GenerateReport heraus und implementiere die Methode in eine eigene Klasse
    public class ReportGenerator
    {
        public void GenerateReport(Employee em)
        {

        }
    }
    #endregion
}
