using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SuperbRecipe.Models
{
    public class DessertRepository : IDessertRepository
    {
        private readonly AppDbContext _appDbContext;
        public DessertRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Dessert> AllDesserts
        {
            get
            {
                return _appDbContext.Desserts.Include(c => c.Category);
            }
        }


        public IEnumerable<Dessert> DessertofWeek
        {
            get
            {
                return _appDbContext.Desserts.Include(c => c.Category).Where(p => p.DessertofWeek);
            }
        }

        public Dessert GetDessertById(int dessertId)
        {
            return _appDbContext.Desserts.FirstOrDefault(p => p.DessertId == dessertId);
        }
    }
}

