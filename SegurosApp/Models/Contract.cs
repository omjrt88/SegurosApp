namespace SegurosApp.Models
{
    using System;
    using SegurosApp.Common.Enums;

    public class Contract
    {
        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int PolicyId { get; set; }

        public Policy Policy { get; set; }

        public string ContractNumber { get; set; }

        public DateTime CreateDate { get; set; }

        public ContractStatus Status { get; set; }
    }
}