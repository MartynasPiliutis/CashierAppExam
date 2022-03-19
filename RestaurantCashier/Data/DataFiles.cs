using System.IO;


namespace RestaurantCashier
{
    internal class DataFiles
    {
        public static readonly string tablesFile = Path.GetFullPath(@"..\..\..\csv\TablesList.csv");
        public static readonly string foodMenuFile = Path.GetFullPath(@"..\..\..\csv\FoodMenu.csv");
        public static readonly string drinksMenuFile = Path.GetFullPath(@"..\..\..\csv\DrinksMenu.csv");
        public static readonly string orderIdsFile = Path.GetFullPath(@"..\..\..\csv\UsedOrderIDs.txt");
        public static readonly string clientReceptsData = Path.GetFullPath(@"..\..\..\Receipts\Client\");
        public static readonly string restaurantReceptsData = Path.GetFullPath(@"..\..\..\Receipts\Restaurant\");
        public static readonly string receiptPrinterClient = Path.GetFullPath(@"..\..\..\Receipts\Printer\clientPrint.txt");
        public static readonly string receiptPrinterRestaurant = Path.GetFullPath(@"..\..\..\Receipts\Printer\restaurantPrint.txt");
    }
}
