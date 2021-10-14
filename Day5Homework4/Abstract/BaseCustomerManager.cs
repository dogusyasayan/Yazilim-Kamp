using Day5Homework4.Abstract;
using Day5Homework4.Entities;
using Day5Homework4.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework4.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
