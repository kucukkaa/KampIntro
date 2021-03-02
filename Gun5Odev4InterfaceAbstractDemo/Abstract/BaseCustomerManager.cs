using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4InterfaceAbstractDemo.Abstract;
using Gun5Odev4InterfaceAbstractDemo.Entities;
using Gun5Odev4InterfaceAbstractDemo.Concrete;

namespace Gun5Odev4InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db: " + customer.FirstName);
        }
    }
}
