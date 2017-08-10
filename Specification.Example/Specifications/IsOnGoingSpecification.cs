using System;
using System.Linq.Expressions;
using Specification.Example.Models;
using Specification.Specifications;

namespace Specification.Example.Specifications
{
    public class IsOnGoingSpecification : Specification<Contract>
    {
        public override Expression<Func<Contract, bool>> IsSatisfiedByExpression
            => c => c.Status == ContractStatus.OnGoing;
    }
}