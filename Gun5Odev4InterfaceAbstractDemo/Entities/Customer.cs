using System;
using Gun5Odev4InterfaceAbstractDemo.Abstract;

namespace Gun5Odev4InterfaceAbstractDemo.Entities
{

    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}

