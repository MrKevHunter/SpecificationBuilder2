using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NUnit.Framework;
using SpecificationBuilder.Specifications;

namespace SpecificationBuilder.Tests
{
    [TestFixture]
    public class SpecTests
    {
        private List<Contact> GetContacts()
        {
            return new List<Contact>
                       {
                           new Contact
                               {
                                   FirstName = "Kev",
                                   LastName = "Hunter",
                                   Age = 32,
                                   BirthDate = DateTime.Parse("23 Aug 1978")
                               },
                           new Contact
                               {
                                   FirstName = "Guy",
                                   LastName = "Thomas",
                                   Age = 65,
                                   BirthDate = DateTime.Parse("20 Oct 1945")
                               }
                       };
        }

        [Test]
        public void CombineTwoQueries()
        {
            List<Contact> contacts = GetContacts();
            Expression<Func<Contact, bool>> expression = PredicateBuilder.True<Contact>().And(
                new LastNameStartsWithSpecification().BuildExpression("Hunter")).And(
                    new AgeIsLessThanSpecification().BuildExpression(50));

            int count = contacts.Where(expression.Compile()).Count();
            Assert.That(count == 1);
        }

        [Test]
        public void EnumerateTwoSpecifications()
        {
            var postCodeStartsWithSpecification = new LastNameStartsWithSpecification();
            Func<Contact, bool> func = postCodeStartsWithSpecification.BuildExpression("Hunter").Compile();
            List<Contact> contacts = GetContacts();

            Assert.That(contacts.Where(func).Count() == 1);
        }
    }
}