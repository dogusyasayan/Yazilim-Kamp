using Day5Homework4.Abstract;
using Day5Homework4.Entities;
using Day5Homework4.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework4.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService customerCheckService;
        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);

            base.Save(customer);
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
