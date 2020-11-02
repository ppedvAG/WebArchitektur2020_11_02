using System;

namespace Part2_OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region Bad Code
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool InsertInEmployeeTable(Employee em)
        {
            //Speichere in die Datenbank

            return true;
        }
    }

    public class ReportGenerator
    {
        public string ReportType { get; set; }

        public void GenerateReport (Employee em)
        {
            if (ReportType == "CRS")
            {
                //Report für CrystalReport
            }
            else if (ReportType == "PDF")
            {
                //PDF wird generiert
            }
            else
            {
                //CSV
            }
        }
    }

    #endregion


    #region Better Variant
    public class ReportGeneratorBase
    {
        public virtual void GenerateReport(Employee em) //Open Part
        {
            //Basis-Einstellungen (Allgemeinde Dinge wir Initialisierung (auslesen Config-Datei)
        }
    }

    

    public class CrystalReportGenerator : ReportGeneratorBase
    {
        public override void GenerateReport (Employee em) //Close Part
        {
            //Generate


            //Mal angenommen es gibt hier ein Fehler. Hast du die Möglichkeit auch CRExpetions zu verwenden. 
            //Bezogene Implementierung für CrystalReports
        }
    }


    public class PDFReportGenerator : ReportGeneratorBase
    {
        public override void GenerateReport(Employee em)
        {
            //Generate
        }
    }
    #endregion


    #region Weitere Variante mit OpenClosed

    public abstract class ReportGeneratorBaseWeitereVariante2
    {
        public abstract void GenerateReport(Employee em); //Open Part

    }
    public class CrystalReportGeneratorVariante2 : ReportGeneratorBaseWeitereVariante2
    {
        public override void GenerateReport(Employee em)
        {
            //Generiere Report
        }
    }
    #endregion
}
