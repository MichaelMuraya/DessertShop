using SuperbRecipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Dessert> DessertOfWeek { get; set; }
    }
}
