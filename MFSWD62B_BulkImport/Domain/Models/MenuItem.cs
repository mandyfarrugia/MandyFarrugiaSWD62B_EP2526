using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    /// <summary>
    /// A model class representing a menu item which can be related to one specific restaurant by means of the RestaurantId attribute.
    /// Each instance of thereof requires approval of the owner of the restaurant. Once approved, the menu items will be visible to the public catalogue if and only if they approved by the restaurant owner.
    /// </summary>
    public class MenuItem
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
        public int RestaurantId { get; set; }
        public bool IsApproved { get; set; }
    }
}