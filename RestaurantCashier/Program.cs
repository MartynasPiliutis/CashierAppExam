using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantCashier
{
    public static class Program
    {
        public static TablesRepository tablesRepository = new();
        public static FoodRepository foodRepository = new();
        public static DrinksRepository drinksRepository = new();
        public static TableOrderRepository tableOrderRepository = new();
        public static OrderRepository orderRepository = new();
        public static MenuActions menuActions = new();
        public static ServingTables servingTables = new();
        public static ReceiptGenerator orderDelivery = new();
        public static ReceiptsSavePrint receiptsRepository = new();

#pragma warning disable IDE0059
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
