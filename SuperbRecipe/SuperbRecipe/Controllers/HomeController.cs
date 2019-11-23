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
    public class HomeController : Controller
    {
        private readonly IDessertRepository _dessertRepository;
        public HomeController(IDessertRepository dessertRepository)
        {
            _dessertRepository = dessertRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                DessertOfWeek = _dessertRepository.DessertofWeek
            };
            return View(homeViewModel);
        }
    }
}
