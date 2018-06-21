namespace SegurosApp.Models
{
    using System;
    using System.Collections.Generic;
    using SegurosApp.Common.Enums;

    public class Client
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender GenderType { get; set; }

        public DateTime Birthday { get; set; }

        public string Nationality { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Policy> Policies { get; set; }

        public Client()
        {
            this.Policies = new HashSet<Policy>();
        }
    }
}