using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5TheGame.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PlayerName { get; set; }
        public double Money { get; set; }
    }
}
