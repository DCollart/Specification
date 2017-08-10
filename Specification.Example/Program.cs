using System;
using System.Collections.Generic;
using System.Linq;
using Specification.Example.Models;
using Specification.Example.Specifications;
using Specification.Helpers;

namespace Specification.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contract> contracts = new List<Contract>()
            {
                new Contract() { ContractNumber = "A", StartDate = DateTime.Now.AddDays(-1), Status = ContractStatus.OnGoing },
                new Contract() { ContractNumber = "B", StartDate = DateTime.Now.AddMonths(-1), Status = ContractStatus.OnGoing },
                new Contract() { ContractNumber = "C", StartDate = DateTime.Now.AddMonths(1), Status = ContractStatus.OnGoing },
                new Contract() { ContractNumber = "D",StartDate = DateTime.Now, Status = ContractStatus.DefinitivelyBlocked },
                new Contract() { ContractNumber = "E",StartDate = DateTime.Now.AddMonths(-1), Status = ContractStatus.DefinitivelyBlocked },
                new Contract() { ContractNumber = "F",StartDate = DateTime.Now.AddMonths(1), Status = ContractStatus.DefinitivelyBlocked },
            };


            // We can use the specification to filter an in memory list or a database thanks to the expression.
            var isInProductionSpec = new IsInProductionSpecification();
            var inProductionContracts = contracts.Where(isInProductionSpec);
            Console.WriteLine($"In production contract count : {inProductionContracts.Count()}");

            // You can also use the specification to validate a single object 
            var isBlockedSpec = new IsBlockedSpecification();
            var contract = contracts.FirstOrDefault();
            var result = isBlockedSpec.IsSatisfiedBy(contract);

            // You can also invoke the "IsSatisfiedBy" from the entity thanks to the extension method
            //var result = contract.IsSatisfiedBy(isBlockedSpec);
            Console.WriteLine(result ? "This contract is blocked" : "This contract is not blocked");
            Console.ReadLine();
        }


    }
}
