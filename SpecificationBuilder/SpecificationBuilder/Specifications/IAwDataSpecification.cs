using System;
using System.Linq;
using System.Linq.Expressions;
using Domain;

namespace SpecificationBuilder.Specifications
{
    public interface IAwDataSpecification
    {
        Expression<Func<Vendor, bool>> BuildExpression(AwContext context,object input);
    }

    public class AwDataSpecification : IAwDataSpecification
    {
        public Expression<Func<Vendor, bool>> BuildExpression(AwContext context, object input)
        {
            var queryable = from v in context.Vendor
                            where v.Name == "Kev"
                            select v;

        }
    }
}