using System;

namespace Part3_Liskov_Substitution_Principle_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region BadCode
    public abstract class Employee
    {
        public virtual string GetProjectDetails(int id)
        {
            return "Ausgabe Basis-Methode";
        }

        public virtual string GetEmployeeDetails(int id)
        {
            return "Ausgabe Basis-Methode";
        }
    }

    public class ContractEmployee : Employee
    {
        public override string GetEmployeeDetails(int id)
        {
            return base.GetEmployeeDetails(id);
        }

        public override string GetProjectDetails(int id)
        {
            return base.GetProjectDetails(id);
        }
    }

    public class CasualEmployee : Employee
    {
        public override string GetEmployeeDetails(int id)
        {
            //Abgeleitetede Methode ist eine Spezialisierung der Basis-Methode und beinhaltet keine andere Logikansätze
            return base.GetEmployeeDetails(id);
        }

        public override string GetProjectDetails(int id)
        {
            return base.GetProjectDetails(id);
        }
    }

    #endregion


    #region Better Code (Für Interface ist Regel 4 gedacht) 

    public interface IBaseProject
    {
        string GetEmployeeDetails(int employeeId);
        string GetProjectDetails(int employeeId);
    }

    public class TestProject : IBaseProject
    {
        public string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }

        public string GetProjectDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }



   

    #endregion
}
