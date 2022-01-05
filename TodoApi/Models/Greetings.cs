using System;
using System.Collections.Generic;

#nullable disable

namespace TodoApi.Models
{
    public partial class Greetings
    {
        public Greetings()
        {
        }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<Battery> Batteries { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<Intervention> Interventions { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<Elevator> Elevators { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
}
}
}
