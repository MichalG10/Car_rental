using System;
using System.Collections.Generic;

namespace Car_rental.Models
{
    public partial class Users
    {
        public Users()
        {
            Rent = new HashSet<Rent>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public int? PhoneNumber { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        public ICollection<Rent> Rent { get; set; }
    }
}
