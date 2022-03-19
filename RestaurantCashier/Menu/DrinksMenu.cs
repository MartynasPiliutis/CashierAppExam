using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class DrinksMenu : Menu
    {
        public DrinksMenu(string menuName, int drinkId, string drinkName, int drinkQuantity, string drinkUnit, double drinkPrice) : base(menuName, drinkId, drinkName, drinkQuantity, drinkUnit, drinkPrice) { }

    }
}
