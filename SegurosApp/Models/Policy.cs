namespace SegurosApp.Models
{
    using System;
    using System.Collections.Generic;
    using SegurosApp.Common.Enums;

    public class Policy
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PolicyTypes Type { get; set; }

        public DateTime InitialDate { get; set; }

        public int CoverTime { get; set; }

        public decimal Price { get; set; }

        public RiskType RiskLevel { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public Policy()
        {
            this.Clients = new HashSet<Client>();
        }
    }
}