using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4InterfaceAbstractDemo.Abstract;
using Gun5Odev4InterfaceAbstractDemo.Entities;

namespace Gun5Odev4InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService

    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
