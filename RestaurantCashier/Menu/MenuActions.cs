using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class MenuActions
    {
        public List<Menu> GetProductDataById(int currentId)
        {
            var selectedProduct = new List<Menu>();
            if (currentId < 22200)
            {
                var menu = Program.foodRepository.LoadFoodsMenu();
                foreach (var item in menu)
                {
                    if (item.ItemID == currentId)
                    {
                        selectedProduct.Add(item);
                    }
                }
            }
            else
            {
                var menu = Program.drinksRepository.LoadDrinksMenu();
                foreach (var item in menu)
                {
                    if (item.ItemID == currentId)
                    {
                        selectedProduct.Add(item);
                    }
                }
            }
            return selectedProduct;
        }
    }
}
