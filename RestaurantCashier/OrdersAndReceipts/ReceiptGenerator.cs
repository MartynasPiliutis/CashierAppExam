using System;
using System.Collections.Generic;

namespace RestaurantCashier
{
    public class ReceiptGenerator
    {
        public List<string> GenerateClientReceipt(string tableName, int orderId, List<TableOrder> currentTableOrder)
        {
            string firstLine = String.Format("{0, -15} {1,-10} {2,-10} {3,-10}", $"Client", $"{tableName}", $"Receipt", $"{orderId}");
            string seperator = "--------------------------------------------------";
            string nextLine = "";
            List<string> clientReceipt = new List<string>();
            clientReceipt.Add(seperator);
            clientReceipt.Add(firstLine);
            clientReceipt.Add(seperator);
            foreach (var item in currentTableOrder)
            {
                nextLine = String.Format("{0, -25} {1,-10} {2,-10}", $"{item.ItemName}", $"{ item.OrderQuantity}", $"{item.TotalItemPrice.ToString("C")}");
                clientReceipt.Add(nextLine);
            }
            clientReceipt.Add(seperator);
            nextLine = String.Format("{0, -15} {1,-15} {2,-15}", $"{tableName}", $"Total Price:", $"{GetTotalOrderPrice(currentTableOrder).ToString("C")}");
            clientReceipt.Add(nextLine);
            clientReceipt.Add(seperator);
            nextLine = $"{DateTime.Now}";
            clientReceipt.Add(nextLine);
            return clientReceipt;
        }

        public List<string> GenerateRestaurantReceipt(string tableName, int orderId, int tableId, List<TableOrder> currentTableOrder)
        {
            string firstLine = String.Format("{0, -15} {1,-10} {2,-10} {3,-10}", $"Restaurant", $"{tableName}", $"Receipt", $"{orderId}");
            string seperator = "--------------------------------------------------";
            string nextLine = "";
            List<string> restaurantReceipt = new List<string>();
            restaurantReceipt.Add(seperator);
            restaurantReceipt.Add(firstLine);
            restaurantReceipt.Add(seperator);
            foreach (var item in currentTableOrder)
            {
                nextLine = String.Format("{0, -6} {1,-24} {2,-5} {3,-10}", $"{item.ItemID}", $"{item.ItemName}", $"{ item.OrderQuantity}", $"{item.TotalItemPrice.ToString("C")}");
                restaurantReceipt.Add(nextLine);
            }
            restaurantReceipt.Add(seperator);
            nextLine = String.Format("{0, -10} {1,-10} {2,-15} {3,-10}", $"{tableName}", $"{tableId}", $"Total Price:", $"{GetTotalOrderPrice(currentTableOrder).ToString("C")}");
            restaurantReceipt.Add(nextLine);
            restaurantReceipt.Add(seperator);
            nextLine = $"{DateTime.Now}";
            restaurantReceipt.Add(nextLine);
            return restaurantReceipt;
        }

        public double GetTotalOrderPrice(List<TableOrder> ListToCount)
        {
            double finalPrice = 0;
            foreach (var item in ListToCount)
            {
                finalPrice = finalPrice + item.TotalItemPrice;
            }
            return finalPrice;
        }

        public List<string> ReceiptPrintCutterLine()
        {
            List<string> cutterLine = new();
            string line = "------------------------------------------------------------";
            string cutter = "-CUT LINE--CUT LINE--CUT LINE--CUT LINE--CUT LINE--CUT LINE-";
            cutterLine.Add(line);
            cutterLine.Add(cutter);
            cutterLine.Add(line);
            return cutterLine;
        }
    }
}
