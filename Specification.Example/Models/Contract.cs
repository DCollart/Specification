using System;

namespace Specification.Example.Models
{
    public class Contract
    {
        public string ContractNumber { get; set; }
        public DateTime StartDate { get; set; }
        public ContractStatus Status { get; set; }         
    }
}