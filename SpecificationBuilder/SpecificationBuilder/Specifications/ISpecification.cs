using System;
using System.Linq.Expressions;

namespace SpecificationBuilder.Specifications
{
    public interface ISpecification<in T>
    {
        Expression<Func<Contact, bool>> BuildExpression(T x);
    }

    /*



    public class LastNameStartsWithSpecification : ISpecification<object>
    {
        #region ISpecification<object> Members

        public Expression<Func<Contact, bool>> BuildExpression(object x)
        {
            return (c) => c.LastName.StartsWith((string) x);
        }

        #endregion
    }

    public class AgeIsLessThanSpecification : ISpecification<object>
    {
        public Expression<Func<Contact, bool>> BuildExpression(object x)
        {
            return (c) => c.Age < (int) x;
        }
    }

    public class PostcodeSpecification : ISpecification<object>
    {
        public Expression<Func<Contact, bool>> BuildExpression(object x)
        {
            throw new NotImplementedException();
        }
    }
*/
}