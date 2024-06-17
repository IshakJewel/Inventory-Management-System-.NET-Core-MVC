using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ShipmentType
    {
        public int shipmentTypeId { get; set; }
        [Required]  
        public string shipmentTypeName { get; set;}
        public string Description { get; set; }
    }
}
