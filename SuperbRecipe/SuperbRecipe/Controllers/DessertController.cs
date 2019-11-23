using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperbRecipe.Models;
using SuperbRecipe.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperbRecipe.Controllers
{
    public class DessertController : Controller
    {
        private readonly IDessertRepository _dessertRepository;
        private readonly ICategoryRepository _categoryRepository;
        

        public DessertController(IDessertRepository dessertRepository,ICategoryRepository categoryRepository)
        {
            _dessertRepository = dessertRepository;
            _categoryRepository = categoryRepository;

        }

        //public ViewResult List()
        //{
        //    DessertListViewModel dessertListViewModel = new DessertListViewModel();
        //    dessertListViewModel.Desserts = dessertRepo.AllDesserts;

        //    dessertListViewModel.CurrentCategory = "Cheese cakes";
        //    return View(dessertListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Dessert> desserts;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                desserts = _dessertRepository.AllDesserts.OrderBy(p => p.DessertId);
                currentCategory = "All pies";
            }
            else
            {
                desserts = _dessertRepository.AllDesserts.Where(p => p.Category.CategoryName == category).OrderBy(p => p.DessertId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new DessertListViewModel
            {
                Desserts = desserts,
                CurrentCategory = currentCategory
            });
        }
            public IActionResult Details(int id)
            {
                var dessert = _dessertRepository.GetDessertById(id);
                if (dessert == null)

                    return NotFound();
                return View(dessert);

            }
            //public IActionResult Details(int id)
            //{
            //    var dessert = _dessertRepository.GetDessertById(id);
            //    if (dessert == null)
            //        return NotFound();
            //    return View(dessert);



            //    //}
            //}

        }
}
