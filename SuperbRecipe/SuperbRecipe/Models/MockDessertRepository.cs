using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.Models
{
    public class MockDessertRepository : IDessertRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
            public IEnumerable<Dessert> AllDesserts =>
        new List<Dessert>
       {

            new Dessert{DessertId=1,Name="Fruit pies",Price= 12.45M, ShortDescription="All-fruity pies",LongDescription="All-fruity pies"},
            new Dessert{DessertId=2,Name="Fruit pies",Price= 13.45M ,ShortDescription="All-fruity pies",LongDescription="All-fruity pies "},
            new Dessert{DessertId=3,Name="Fruit pies",Price= 15.45M, ShortDescription="All-fruity pies",LongDescription="All-fruity pies"}

       };

        public IEnumerable<Dessert> DessertofWeek { get; }

        public Dessert GetDessertById(int dessertId)
        {
           return AllDesserts.FirstOrDefault(p=>p.DessertId==dessertId);
        }
    }
}
