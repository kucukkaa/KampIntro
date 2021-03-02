using System;
using Gun5Odev4InterfaceAbstractDemo.Abstract;
using Gun5Odev4InterfaceAbstractDemo.Entities;
using Gun5Odev4InterfaceAbstractDemo.Concrete;
using Gun5Odev4InterfaceAbstractDemo.Adapters;



namespace Gun5Odev4InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{FirstName = "ALİERK", LastName = "KÜÇÜK", Id = 1, NationalityId = 50155561840, DateOfBirth = (new DateTime(1986,11,18))});
            Console.ReadLine();
        }
    }
}
