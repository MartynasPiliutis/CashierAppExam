using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantCashier
{
    public partial class ReceiptDelivery : Form
    {
        public int orderId;
        public int tableId;
        public string tableName;
        public List<TableOrder> tableOrderList;
        public ReceiptDelivery(double finalPrice, int currentOrderId, int currentTableId, List<TableOrder> currentTableOrder)
        {
            InitializeComponent();
            orderId = currentOrderId;
            tableId = currentTableId;
            tableName = Program.tablesRepository.GetTableNameByID(currentTableId);
            tableOrderList = currentTableOrder;
            this.totalPrice.Text = finalPrice.ToString("C");
        }

        private void clientEmail_TextChanged(object sender, EventArgs e)
        {
            this.emailClientButton.Enabled = this.clientEmail.Text == "" || this.clientEmail.Text == "Client Mailbox" ? false : true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new();
            this.Hide();
            mainWindow.ShowDialog();
            this.Close();
        }

        private void clientEmail_Click(object sender, EventArgs e)
        {
            this.clientEmail.Text = this.clientEmail.Text == "Client Mailbox" ? "" : this.clientEmail.Text;
        }

        private void ReceiptDelivery_Click(object sender, EventArgs e)
        {
            this.clientEmail.Text = this.clientEmail.Text == "" ? "Client Mailbox" : this.clientEmail.Text;
        }

        public void payButton_Click(object sender, EventArgs e)
        {
            int printTrigger = this.clientPrintReceipt.Checked == false ? 0 : 1;
            int currentOrderId = Program.orderRepository.GetOrderIdFromOrdersList(tableId);
            Program.receiptsRepository.SaveReceiptToFile(currentOrderId, tableName, tableOrderList, printTrigger);
            tableOrderList.Clear();
            double zero = 0;
            this.totalPrice.Text = zero.ToString("C");
        }

        private void emailClientButton_Click(object sender, EventArgs e)
        {
            string clientEmail = this.clientEmail.Text;
            int currentOrderId = Program.orderRepository.GetOrderIdFromOrdersList(tableId);
            string filenameClient = currentOrderId.ToString();
            filenameClient = filenameClient + "-client" + ".txt";
            ClientEmailSend client = new();
            string clientConfirmation = client.SendEmail(clientEmail, filenameClient);
            EmailConfirmation emailConfirmation = new EmailConfirmation(clientConfirmation);
            emailConfirmation.ShowDialog();

        }
        private void emailRestaurantButton_Click(object sender, EventArgs e)
        {
            string restaurantEmail = "office@restaurant.com";
            int currentOrderId = Program.orderRepository.GetOrderIdFromOrdersList(tableId);
            string filenameRestaurant = currentOrderId.ToString();
            filenameRestaurant = filenameRestaurant + "-restaurant" + ".txt";
            RestaurantEmailSend restaurant = new();
            string restaurantConfirmation = restaurant.SendEmail(restaurantEmail, filenameRestaurant);
            EmailConfirmation emailConfirmation = new EmailConfirmation(restaurantConfirmation);
            emailConfirmation.ShowDialog();
        }
    }
}
