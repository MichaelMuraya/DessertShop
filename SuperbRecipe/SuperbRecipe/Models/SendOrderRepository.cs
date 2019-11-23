using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.Models
{
    public class SendOrderRepository:ISendOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        

        public SendOrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
           
        }

        public void CreateOrder(SendOrder sendorder)
        {
            sendorder.OrderPlaced = DateTime.Now;

            

            sendorder.SendOrderDetails = new List<SendOrderDetail>();
            //adding the order with its details

            

            _appDbContext.SendOrders.Add(sendorder);

            _appDbContext.SaveChanges();
        }
    }
}

