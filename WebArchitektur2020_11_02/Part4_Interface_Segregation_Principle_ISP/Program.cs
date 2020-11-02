using System;
using System.Collections;
using System.Collections.Generic;

namespace Part4_Interface_Segregation_Principle_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IReadonlyRepository<Employee> readonlyRepo = new Repo();

            //readonlyRepo.GetAll(); readonlyRepo.GetById(123);
        }
    }

    #region BadCode
    public interface IBadRepository<T> where T : class
    { 
         IList<T> GetAll(); //Read
         T GetById(int Id);

         void Insert(T entity);
         void Update(T entity);
         void Delete(T entity);
    }

    
    #endregion

    #region Better
    public interface IReadonlyRepository<T> where T : class
    {
        public IList<T> GetAll(); //Read
        public T GetById(int Id);
    }

    public interface IInsertCommand<T> where T : class
    {
        public void Insert(T entity);
    }

    public interface IDeleteCommand<T> where T : class
    {
        public void Delete(T entity);
    }

    public interface IUpdateCommand<T> where T : class
    {
        public void Update(T entity);
    }


    public interface IRepository<T> 
        : IReadonlyRepository<T>, 
        IInsertCommand<T>,
        IDeleteCommand<T>,
        IUpdateCommand<T>  where T : class 

    {
        int Count();
    }


    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //weitere Spalten in Table
    }


    public class Repo : IRepository<Employee>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
