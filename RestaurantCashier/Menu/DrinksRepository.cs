using System.Collections.Generic;

namespace RestaurantCashier
{
    public class DrinksRepository
    {
        public readonly List<Menu> Drinks;
        public DrinksRepository()
        {
            Drinks = new List<Menu>();
            object[,] drinksMenuData = (object[,])FileService.FileReaderService(DataFiles.drinksMenuFile);
            Drinks = FileService.PopulateMenuList(drinksMenuData);
        }

        public List<Menu> LoadDrinksMenu()
        {
            return Drinks;
        }
    }
}
