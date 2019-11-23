using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperbRecipe.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperbRecipe.Controllers
{
    public class SendOrderController : Controller
    {
        private readonly ISendOrderRepository _orderRepository;
        

        public SendOrderController(ISendOrderRepository sendOrderRepository)
        {
            _orderRepository = sendOrderRepository;
           
        }

        // GET: /<controller>/
        public IActionResult OrderSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderSend(SendOrder sendorder)
        {
            

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(sendorder);
                
                return RedirectToAction("SendOrderoutComplete");
            }
            return View(sendorder);
        }

        public IActionResult SendOrderoutComplete()
        {
            ViewBag.SendoutOrderCompleteMessage = "Thanks for your order. We will soon update your Order To our Page!";
            return View();
        }
    }
}

