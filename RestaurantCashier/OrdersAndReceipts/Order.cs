using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TableId { get; set; }

        public Order(int orderId, DateTime orderDate, int tableId)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            TableId = tableId;
        }

    }
}
