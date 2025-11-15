using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OwnerEmailAddress { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsApproved { get; set; }
    }
}