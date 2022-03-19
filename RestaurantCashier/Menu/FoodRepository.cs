using System.Collections.Generic;

namespace RestaurantCashier
{
    public class FoodRepository
    {
        public readonly List<Menu> Foods;
        public FoodRepository()
        {
            Foods = new List<Menu>();
            object[,] foodMenuData = (object[,])FileService.FileReaderService(DataFiles.foodMenuFile);
            Foods = FileService.PopulateMenuList(foodMenuData);
        }
        public List<Menu> LoadFoodsMenu()
        {
            return Foods;
        }
    }
}
