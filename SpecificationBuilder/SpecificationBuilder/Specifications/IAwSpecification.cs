using System;
using System.Linq;
using System.Linq.Expressions;
using Domain;

namespace SpecificationBuilder.Specifications
{
    public interface IAwSpecification
    {
        Expression<Func<Vendor, bool>> BuildExpression(object input);
    }

    public class VendorContactNameSpecification : IAwSpecification
    {
        public Expression<Func<Vendor, bool>> BuildExpression(object input)
        {
            return (v) => v.Contacts.Any( c =>  c.LastName.StartsWith((string) input));
        }
    }

    public class VendorNameStartsWithSpecification : IAwSpecification
    {
        public Expression<Func<Vendor, bool>> BuildExpression(object input)
        {
            return (c) => c.Name.StartsWith((string)input);

        }
    }
}