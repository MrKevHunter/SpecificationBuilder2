using System;
using System.Collections.Generic;

namespace Domain
{
    public class Vendor
    {
        public int VendorId { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string PurchasingWebServiceUrl { get; set; }

        public bool PreferredVendorStatus { get; set; }
        public bool ActiveFlag { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}