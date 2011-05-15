using System.Collections;
using System.Collections.Generic;
using SpecificationBuilder.Specifications;

namespace SpecificationBuilder
{
    public class SpecificationAggregate
    {
       
        private List<ISpecification<string>> specs = new List<ISpecification<string>>();

        public void AddSpec(ISpecification<string> spec)
        {
            specs.Add(spec);
        }
    }
}