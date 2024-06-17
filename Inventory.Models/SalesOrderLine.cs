using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class SalesOrderLine
    {
        public int Id { get; set; }
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public double Quentity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public double DiscountPercentage { get; set; }
        public double DiscountAmount { get; set; }
        public double SubTotal { get; set; }
        public double TexPercentage { get; set; }
        public double TexAmount { get; set; }   
        public double Total { get; set; }


    }
}
