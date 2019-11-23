using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.Models
{
    public class SendOrderDetail
    {
        public int SendOrderDetailId { get; set; }
        public int SendOrderId { get; set; }
        public int DessertId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Dessert Dessert { get; set; }
        public SendOrder SendOrder { get; set; }
    }
}
