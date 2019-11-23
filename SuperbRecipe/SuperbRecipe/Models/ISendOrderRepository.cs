using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.Models
{
    public interface ISendOrderRepository
    {
        void CreateOrder(SendOrder sendorder);
    }
}
