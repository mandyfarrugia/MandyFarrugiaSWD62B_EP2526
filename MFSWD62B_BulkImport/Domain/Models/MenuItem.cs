using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MenuItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int RestaurantId { get; set; }
        public string Status { get; set; }
    }
}