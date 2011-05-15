using System;

namespace SpecificationBuilder
{
    public class Contact : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }   
    
    }
}