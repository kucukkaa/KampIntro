using System;

namespace Gun5Odev1Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManger = new PersonManager();

            Customer customer1 = new Customer()
            {
                FirstName = "ali",
                LastName = "veli",
                Id = 1,
                Address = "istanbul"
            };

            Student student1 = new Student()
            { FirstName = "kemal",
            LastName = "mehmet",
            Id = 2,
            Departmant ="computer sciences"
            };



            personManger.Add(customer1);
            personManger.Add(student1);


            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            //customerManager.Add(new OracleCustomerDal());


            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
                
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set ; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
