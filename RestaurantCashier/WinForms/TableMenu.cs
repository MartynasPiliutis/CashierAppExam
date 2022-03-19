using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantCashier
{
    public partial class TableMenu : Form
    {
        public int currentTableId;
        public int currentOrderId;
        List<Tables> tables = Program.tablesRepository.Tables;
        List<TableOrder> currentTableOrder = new();
        List<Tables> currentTable = new();


        public TableMenu(int inputTableId, List<TableOrder> inputOrderList)
        {
            InitializeComponent();
            {
                currentTableId = inputTableId;
                currentTableOrder = inputOrderList;
            }
            SetButtons(this.button1, this.button2, this.button3, inputTableId, tables);
        }

        public static bool SetButtonsIfTableFree(int getTableId, List<Tables> tables)
        {
            bool tableOcupied = false;
            foreach (var item in tables)
            {
                if (item.TableID == getTableId)
                {
                    tableOcupied = !item.TableFree;
                }
            }
            return tableOcupied;
        }

        public static List<Tables> GetTableData(int gotTableId, List<Tables> tables)
        {
            List<Tables> gatDataTable = new();
            foreach (var item in tables)
            {
                if (item.TableID == gotTableId)
                {
                    int currentTableId = gotTableId;
                    string currentTableName = item.TableName;
                    int currentTableSeats = item.TableSeats;
                    bool currentTableFree = false;
                    gatDataTable.Add(new Tables(currentTableId, currentTableName, currentTableSeats, currentTableFree));
                }
            }
            return gatDataTable;
        }
        private void OrderClose_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new();
            this.Hide();
            mainWindow.ShowDialog();
            this.Close();
        }

        public void OrderStart_Click(object sender, EventArgs e)
        {

            foreach (var item in tables)
            {
                if (item.TableID == currentTableId)
                {
                    item.TableFree = false;
                }
            }

            currentTable = GetTableData(currentTableId, tables);

            foreach (var item in currentTable)
            {
                item.TableFree = item.TableID == currentTableId ? false : true;
                button1.Enabled = item.TableFree == false ? false : true;
                button2.Enabled = button1.Enabled == false ? true : false;
                button3.Enabled = button1.Enabled == false ? true : false;
            }
            currentOrderId = Program.servingTables.OrderIDGenerator();
            Program.orderRepository.AddOrderDetails(currentTableId, currentOrderId);
        }

        private void OrderNewAdd_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = new OrderingForm(currentTableId, currentOrderId, currentTableOrder);
            this.Hide();
            orderingForm.ShowDialog();
            this.Close();
        }

        public void SetButtons(Button button1, Button button2, Button button3, int getTableId, List<Tables> tables)
        {
            button3.Enabled = Program.orderDelivery.GetTotalOrderPrice(currentTableOrder) != 0 ? true : false;
            button1.Enabled = SetButtonsIfTableFree(getTableId, tables) == true ? false : true;
            button2.Enabled = SetButtonsIfTableFree(getTableId, tables) == true ? true : false;
            button3.Enabled = SetButtonsIfTableFree(getTableId, tables) == true ? true : false;
        }

        public void PayClose_Click(object sender, EventArgs e)
        {
            double finalPrice = Program.orderDelivery.GetTotalOrderPrice(currentTableOrder);
            ReceiptDelivery receiptDelivery = new ReceiptDelivery(finalPrice, currentOrderId, currentTableId, currentTableOrder);
            this.Hide();
            receiptDelivery.ShowDialog();
            this.Close();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in tables)
            {
                if (item.TableID == currentTableId)
                {
                    item.TableFree = true;
                }
            }

            currentTable = GetTableData(currentTableId, tables);

            foreach (var item in currentTable)
            {
                item.TableFree = item.TableID == currentTableId ? true : false;
                button1.Enabled = item.TableFree == true ? true : false;
                button2.Enabled = button1.Enabled == true ? false : true;
                button3.Enabled = button1.Enabled == true ? false : true;
            }

            currentTableId = new();
            currentOrderId = new();
            tables = Program.tablesRepository.Tables;
            currentTable = new();
            currentTableOrder.Clear();
            MainWindow mainWindow = new();
            this.Hide();
            mainWindow.ShowDialog();
            this.Close();

        }
    }
}
