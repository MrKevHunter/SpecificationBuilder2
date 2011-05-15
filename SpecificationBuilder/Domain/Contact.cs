﻿using System.Collections.Generic;

namespace Domain
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int EmailPromotion { get; set; }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName   { get; set; }
        public string Suffix { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}