using System;
using System.Linq.Expressions;
using Specification.Example.Models;
using Specification.Specifications;

namespace Specification.Example.Specifications
{
    public class IsBlockedSpecification : Specification<Contract>
    {
        public override Expression<Func<Contract, bool>> IsSatisfiedByExpression
            => c => c.Status == ContractStatus.DefinitivelyBlocked || c.Status == ContractStatus.TemporaryBlocked;
    }
}