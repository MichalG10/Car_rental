using System;
using System.Collections.Generic;

namespace Car_rental.Models
{
    public partial class Rent
    {
        public int IdRent { get; set; }
        public int? IdCar { get; set; }
        public int? IdUser { get; set; }

        public Cars IdCarNavigation { get; set; }
        public Users IdUserNavigation { get; set; }
    }
}
