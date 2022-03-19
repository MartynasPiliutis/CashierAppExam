using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class Menu
    {
        public string MenuName { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public string ItemUnit { get; set; }
        public double ItemPrice { get; set; }

        public Menu(string menuName, int itemID, string itemName, int itemQuantity, string itemUnit, double itemPrice)
        {
            MenuName = menuName;
            ItemID = itemID;
            ItemName = itemName;
            ItemQuantity = itemQuantity;
            ItemUnit = itemUnit;
            ItemPrice = itemPrice;
        }
    }
}
