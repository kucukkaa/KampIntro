﻿using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4InterfaceAbstractDemo.Entities;

namespace Gun5Odev4InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
