using parkareSolution.Domain.Interfaces;
using System;

namespace parkareSolution.Application
{
    public class Repository<T> : IRepository<T>
    {
        //private readonly SomeContext _context;
        //public Repository(SomeContext context)
        //{
        //    _context = context;
        //}
       
        public void Save(T item)
        {
            Console.WriteLine($"Save Class: {item.GetType().Name}");
        }
    }
}
