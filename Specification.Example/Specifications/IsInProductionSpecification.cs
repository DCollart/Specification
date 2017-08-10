using Specification.Example.Models;
using Specification.Specifications;

namespace Specification.Example.Specifications
{
    public class IsInProductionSpecification : AndSpecification<Contract>
    {
        public IsInProductionSpecification() : base(new IsOnGoingSpecification(), new IsStartedSpecification())
        {
        }
    }
}