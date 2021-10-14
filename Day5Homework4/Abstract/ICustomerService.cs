using Day5Homework4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework4.Abstract
{
    public interface ICustomerCheckService
    {
        public void Save(Customer customer);
    }
}
