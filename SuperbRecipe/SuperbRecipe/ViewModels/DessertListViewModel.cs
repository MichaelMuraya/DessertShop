using SuperbRecipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.ViewModels
{
    public class DessertListViewModel
    {
        public IEnumerable<Dessert> Desserts { get; set; }
        public string CurrentCategory { get; set; }

    }
}
