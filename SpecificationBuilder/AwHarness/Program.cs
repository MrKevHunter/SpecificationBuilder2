using System;
using System.Linq;
using System.Linq.Expressions;
using Domain;
using SpecificationBuilder;
using SpecificationBuilder.Specifications;
using Contact = Domain.Contact;

namespace AwHarness
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new AwContext())
            {

                var expression =
                    PredicateBuilder.True<Vendor>().And(new VendorContactNameSpecification().BuildExpression("W"));

                expression = expression.And(vendor => vendor.ActiveFlag);
                foreach (var s in context.Vendor.Where(expression))
                {
                    Console.WriteLine(s.Name);
                }

            }
            Console.ReadLine();
        }
    }
}