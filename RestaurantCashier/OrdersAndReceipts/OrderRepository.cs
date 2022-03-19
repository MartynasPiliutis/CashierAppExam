using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class OrderRepository
    {
        public List<Order> Orders;
        public OrderRepository()
        {
            Orders = new List<Order>();
        }

        public void AddOrderDetails(int inputTableId, int inputOrderId)
        {
            int triggerExist = 0;
            foreach (var item in Orders)
            {
                triggerExist = item.OrderId == inputOrderId ? 1 : 0;
                triggerExist = item.TableId == inputTableId ? 1 : 0;
            }
            if (triggerExist == 0)
            {
                DateTime orderDate = DateTime.Now;
                Orders.Add(new Order(inputOrderId, orderDate, inputTableId));
            }
        }

        public int GetTableIdFromOrdersList(int inputOrderId)
        {
            int tableId = 0;
            foreach (var item in Orders)
            {
                if (item.OrderId == inputOrderId)
                {
                    tableId = item.TableId;
                }       
            }
            return tableId;
        }

        public int GetOrderIdFromOrdersList(int inputTableId)
        {
            int OrderId = 0;
            foreach (var item in Orders)
            {
                if (item.TableId == inputTableId)
                {
                    OrderId = item.OrderId;
                }
            }
            return OrderId;
        }

        public void ClearOrderInformationByTableId(int tableIdToClear)
        {
            foreach (var item in Orders)
            {
                if (item.TableId == tableIdToClear)
                {
                    Orders.Remove(item);
                }
            }
        }
    }

}
