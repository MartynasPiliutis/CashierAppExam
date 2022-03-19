using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#pragma warning disable CS8600
#pragma warning disable CS8604
#pragma warning disable IDE0059

namespace RestaurantCashier
{
    public class ServingTables
    {
        public int OrderIDGenerator()
        {
            var tempArray = File.ReadAllLines(DataFiles.orderIdsFile);
            List<int> usedOrderIds = new();
            foreach (var item in tempArray) { usedOrderIds.Add(Convert.ToInt32(item)); }
            int lastOrderId = usedOrderIds.Select(i => i).Max();
            int newOrderId = lastOrderId+1;
            File.AppendAllText(DataFiles.orderIdsFile, Environment.NewLine + newOrderId.ToString());
            return newOrderId;
        }

        public void StartNewOrderOnTable(int currentTableId, List<Tables> tables)
        {
            int newOrderId = OrderIDGenerator();
            string currentTableName = "";
            foreach (var item in tables)
            {
                currentTableName = item.TableID == currentTableId ? item.TableName : "";
            }
        }

        public void AddProductToOrder(List<TableOrder> currentOrder, List<Menu> productList, int productToAddId, int currentTableId, int currentOrderId, int currentOrderQnty)
        {
            int tableId = currentTableId;
            int orderId = Program.orderRepository.GetOrderIdFromOrdersList(currentTableId);
            int orderItemId = productToAddId;
            int orderQuantity = currentOrderQnty;
            string orderMenu = "";
            string orderItemName = "";
            string orderItemUnit = "";
    
            foreach (var item in productList)
            {
                orderMenu = item.MenuName;
                orderItemName = item.ItemName;
                orderItemUnit = item.ItemUnit;
            }

            int itemQuantity = productList.Where(x => x.ItemID == productToAddId).Select(x => x.ItemQuantity).FirstOrDefault();
            double orderUnitPrice = productList.Where(x => x.ItemID == productToAddId).Select(x => x.ItemPrice).FirstOrDefault();
            double totalItemPrice = orderUnitPrice * currentOrderQnty;

            currentOrder.Add(new TableOrder(tableId, orderId, orderMenu, orderItemId, orderItemName, itemQuantity, orderQuantity, orderItemUnit, orderUnitPrice, totalItemPrice));
        }

    }
}
