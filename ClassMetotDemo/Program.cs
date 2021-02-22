using System;
using System.Collections;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.CustomerName = "ali";
            customer1.CustomerSurname = "veli";
            customer1.Id = 1;
            customer1.TCKN = "123456789";
            customer1.CustomerAddress = "Ankara";
            customer1.CustomerTelephone = "05555555555";
            customer1.CAccountNumber = "456-45587978";
            customer1.CustomerBalance = 7564.65;

            Customer customer2 = new Customer();
            customer2.CustomerName = "kemal";
            customer2.CustomerSurname = "ziya";
            customer2.Id = 2;
            customer2.TCKN = "98776789";
            customer2.CustomerAddress = "İstanbul";
            customer2.CustomerTelephone = "0666666666";
            customer2.CAccountNumber = "456-15345789";
            customer2.CustomerBalance = 7845.65;

            Customer[] customerList = new Customer[]{customer1, customer2};
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);


            customerManager.ShowCustomer(1, customerList);

            customerManager.ShowAllCustomers(customerList);

            customerManager.DeleteCustomer(1 , ref customerList);

            


        }
    }
}
