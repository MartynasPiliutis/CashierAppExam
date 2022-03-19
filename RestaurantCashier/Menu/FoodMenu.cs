using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class FoodMenu : Menu
    {
        public FoodMenu(string menuName, int foodId, string foodName, int foodQuantity, string foodUnit, double foodPrice) : base(menuName, foodId, foodName, foodQuantity, foodUnit, foodPrice) { }
    }
}
