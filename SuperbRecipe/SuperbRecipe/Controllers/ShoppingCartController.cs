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
    public class ShoppingCartController : Controller
    {
        private readonly IDessertRepository _dessertRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDessertRepository dessertRepository, ShoppingCart shoppingCart)
        {
            _dessertRepository = dessertRepository;
            _shoppingCart = shoppingCart;

        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal() 
            };

            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int dessertId)
        {
            var selectedDessert = _dessertRepository.AllDesserts.FirstOrDefault(p => p.DessertId == dessertId);
            if (selectedDessert != null)
            {
                _shoppingCart.AddToCart(selectedDessert, 1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int dessertId)
        {
            var selectedDessert = _dessertRepository.AllDesserts.FirstOrDefault(p => p.DessertId == dessertId);
            if (selectedDessert != null)
            {
                _shoppingCart.RemoveFromCart(selectedDessert);
            }
            return RedirectToAction("Index");
        }
    }
}

