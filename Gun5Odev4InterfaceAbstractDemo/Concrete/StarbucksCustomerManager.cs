using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4InterfaceAbstractDemo.Abstract;
using Gun5Odev4InterfaceAbstractDemo.Entities;

namespace Gun5Odev4InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
            
        }

    }
}
