﻿using System;
using System.Collections.Generic;

namespace ProjectLibri.Models
{
    public class User : IModel
    {
        public String displayName { get; set; }
        public String givenName { get; set; }
        public String mail { get; set; }
        public String surname { get; set; }
        public String userPrincipalName { get; set; }
        public String id { get; set; }
        public String className { get; set;}
        public Role role { get; set;}
        //public List<Loan> loans { get; set;}
        //public List<Reservation> reservations { get; set;}




    }
}
