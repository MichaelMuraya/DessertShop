using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public  Dessert Dessert { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
        
    }
}
