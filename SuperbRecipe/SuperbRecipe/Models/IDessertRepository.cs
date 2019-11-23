using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.Models
{
     
    
        public interface IDessertRepository
        {
            IEnumerable<Dessert> AllDesserts { get; }
            IEnumerable<Dessert> DessertofWeek { get; }
            Dessert GetDessertById(int dessertId);

        }
    }
