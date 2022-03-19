using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RestaurantCashier
{
    public partial class OrderingForm : Form
    {
        List<TableOrder> currentTableOrder = new();
        public int currentOrderId;
        public int currentTableId;
        public OrderingForm(int inputTableId, int inpurtOrderId, List<TableOrder> inputTableOrder)
        {
            currentOrderId = inpurtOrderId;
            currentTableId = inputTableId;
            currentTableOrder = inputTableOrder;
            InitializeComponent();
            SetTableOrderInformation(inputTableId, inpurtOrderId);
            LoadCurrentOrder(currentTableOrder);
            this.label3.Text = $"{Program.tablesRepository.GetSeatsByTableId(inputTableId)} Seats";
            TimeUpdater();
        }
        public void buttonFood_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            quantityAdd.Enabled = false;
            quantityAdd.Value = 1;
            List<Menu> foodList = Program.foodRepository.LoadFoodsMenu();
            LoadRestaurantMenu(foodList);
        }
        public void buttonDrinks_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            quantityAdd.Enabled = false;
            quantityAdd.Value = 1;
            List<Menu> drinksList = Program.drinksRepository.LoadDrinksMenu();
            LoadRestaurantMenu(drinksList);
        }
        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            quantityAdd.Enabled = true;
            quantityAdd.Value = 1;
            buttonAdd.Enabled = true;
        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            int selectedQnty = Convert.ToInt32(quantityAdd.Value);
            int selcetedRow = dataGridViewMenu.CurrentRow.Index;
            int selectedId = Convert.ToInt32(dataGridViewMenu.Rows[selcetedRow].Cells[2].Value);

            AddMenuItemToOrder(selectedId, selectedQnty, currentTableId, currentOrderId, currentTableOrder);
        }

        public void LoadRestaurantMenu(List<Menu> listToLoad)
        {
            dataGridViewMenu.Rows.Clear();
            int cellNo = 1;
            int rowNr = 0;
            foreach (var item in listToLoad)
            {
                dataGridViewMenu.Rows.Add();
                dataGridViewMenu.Rows[rowNr].Cells[0].Value = cellNo;
                dataGridViewMenu.Rows[rowNr].Cells[1].Value = item.ItemName;
                dataGridViewMenu.Rows[rowNr].Cells[2].Value = item.ItemID;
                dataGridViewMenu.Rows[rowNr].Cells[3].Value = item.ItemUnit;
                dataGridViewMenu.Rows[rowNr].Cells[4].Value = item.ItemPrice;
                rowNr++;
                cellNo++;
            }
        }

        public void LoadCurrentOrder(List<TableOrder> currentTableOrder)
        {
            dataGridViewOrder.Rows.Clear();
            int cellNo = 1;
            int rowNr = 0;
            foreach (var item in currentTableOrder)
            {
                dataGridViewOrder.Rows.Add();
                dataGridViewOrder.Rows[rowNr].Cells[0].Value = cellNo;
                dataGridViewOrder.Rows[rowNr].Cells[1].Value = item.MenuName;
                dataGridViewOrder.Rows[rowNr].Cells[2].Value = item.ItemName;
                dataGridViewOrder.Rows[rowNr].Cells[3].Value = item.OrderQuantity;
                dataGridViewOrder.Rows[rowNr].Cells[4].Value = item.ItemPrice;
                dataGridViewOrder.Rows[rowNr].Cells[5].Value = item.OrderQuantity * item.ItemPrice;
                rowNr++;
                cellNo++;
            }
            double totalPrice = Program.orderDelivery.GetTotalOrderPrice(currentTableOrder);
            this.totalPrice.Text = totalPrice.ToString("C");
        }

        public void AddMenuItemToOrder(int itemId, int itemQnty, int tableId, int orderId, List<TableOrder> currentTableOrder)
        {
            int rowsCount = dataGridViewOrder.DisplayedRowCount(false);
            var currentList = Program.menuActions.GetProductDataById(itemId);
            int cellNo = rowsCount + 1;
            foreach (var item in currentList)
            {
                dataGridViewOrder.Rows.Add();
                dataGridViewOrder.Rows[rowsCount].Cells[0].Value = cellNo;
                dataGridViewOrder.Rows[rowsCount].Cells[1].Value = item.MenuName;
                dataGridViewOrder.Rows[rowsCount].Cells[2].Value = item.ItemName;
                dataGridViewOrder.Rows[rowsCount].Cells[3].Value = itemQnty;
                dataGridViewOrder.Rows[rowsCount].Cells[4].Value = item.ItemPrice;
                dataGridViewOrder.Rows[rowsCount].Cells[5].Value = itemQnty * item.ItemPrice;
                Program.servingTables.AddProductToOrder(currentTableOrder, currentList, item.ItemID, tableId, orderId, itemQnty);
                double totalPrice = Program.orderDelivery.GetTotalOrderPrice(currentTableOrder);
                this.totalPrice.Text = totalPrice.ToString("C");
            }
        }

        private void buttonMenuBack_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new();
            this.Hide();
            mainWindow.ShowDialog();
            this.Close();
        }

        public void SetTableOrderInformation(int inputTableId, int inputOrderId)
        {
            int orderId = inputOrderId == 0 ? Program.orderRepository.GetOrderIdFromOrdersList(inputTableId) : inputOrderId;
            int tableId = inputTableId == 0 ? Program.orderRepository.GetTableIdFromOrdersList(orderId) : inputTableId;
            string tableName = Program.tablesRepository.GetTableNameByID(tableId);
            this.label2.Text = $"{tableName} {orderId}";
        }
        async void TimeUpdater()
        {
            while (true)
            {
                this.CurrentTime.Text = $"{DateTime.Now}";
                await Task.Delay(1000);
            }
        }
    }
}
