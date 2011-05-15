using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationBuilder
{
    public abstract class EntityBase
    {
        
    }

    public class Address : EntityBase
    {
        public string AddressLine1
        {
            get;
            set;
        }
        public string AddressLine2
        {
            get;
            set;
        }

        public string PostCode { get;set; }
    }
}
