using System;
using System.Linq;
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
                var expression = PredicateBuilder.True<Vendor>();
                foreach (var s in context.Vendor.Where(expression).OrderBy(v => v.Name).Skip(5).Take(5))
                {
                    Console.WriteLine(s.Name);
           
                }

                /*var expression = PredicateBuilder.True<Vendor>().And(new VendorContactNameSpecification().BuildExpression("W"));
                foreach (var s in context.Vendor.Where(expression))
                {
                    Console.WriteLine(s.Name);
                }
*/
            }
            Console.ReadLine();
        }
    }
}