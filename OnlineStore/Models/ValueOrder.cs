using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class ValueOrder
    {
        public ValueOrder(int productId, int orderId)
        {
            productId = ProductId;
            orderId = OrderId;
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
