using System;

namespace Gun5Odev1Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "ali";

            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "ali" }, 
                new Student{FirstName="veli"},
                new Person{FirstName = "kemal"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer:Person
        {
            public string City { get; set; }
        }

        class Student:Person
        {
            public string Departmant { get; set; }
        }
    }
}
