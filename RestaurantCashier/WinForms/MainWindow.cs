using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantCashier
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Table01_Click(object sender, EventArgs e)
        {
            int tableId = 33301;
            List<TableOrder> table01Order = Program.tableOrderRepository.table01Order;
            TableMenu tableMenu = new TableMenu(tableId, table01Order);
            this.Hide();
            tableMenu.ShowDialog();
            this.Close();
        }

        public void Table02_Click(object sender, EventArgs e)
        {
            int tableId = 33302;
            List<TableOrder> table02Order = Program.tableOrderRepository.table02Order;
            TableMenu tableMenu = new TableMenu(tableId, table02Order);
            this.Hide();
            tableMenu.ShowDialog();
            this.Close();
        }

        public void Table03_Click(object sender, EventArgs e)
        {
            int tableId = 33303;
            List<TableOrder> table03Order = Program.tableOrderRepository.table03Order;
            TableMenu tableMenu = new TableMenu(tableId, table03Order);
            this.Hide();
            tableMenu.ShowDialog();
            this.Close();
        }

        public void Table04_Click(object sender, EventArgs e)
        {
            int tableId = 33304;
            List<TableOrder> table04Order = Program.tableOrderRepository.table04Order;
            TableMenu tableMenu = new TableMenu(tableId, table04Order);
            this.Hide();
            tableMenu.ShowDialog();
            this.Close();
        }

        public void Table05_Click(object sender, EventArgs e)
        {
            int tableId = 33305;
            List<TableOrder> table05Order = Program.tableOrderRepository.table05Order;
            TableMenu tableMenu = new TableMenu(tableId, table05Order);
            this.Hide();
            tableMenu.ShowDialog();
            this.Close();
        }

        public void Table06_Click(object sender, EventArgs e)
        {
            int tableId = 33306;
            List<TableOrder> table06Order = Program.tableOrderRepository.table06Order;
            TableMenu tableMenu = new TableMenu(tableId, table06Order);
            this.Hide();
            tableMenu.ShowDialog();
            this.Close();
        }

        public void Table07_Click(object sender, EventArgs e)
        {
            int tableId = 33307;
            List<TableOrder> table07Order = Program.tableOrderRepository.table07Order;
            TableMenu tableMenu = new TableMenu(tableId, table07Order);
            this.Hide();
            tableMenu.ShowDialog();
            this.Close();
        }

        public void Table08_Click(object sender, EventArgs e)
        {
            int tableId = 33308;
            List<TableOrder> table08Order = Program.tableOrderRepository.table08Order;
            TableMenu tableMenu = new TableMenu(tableId, table08Order);
            this.Hide();
            tableMenu.ShowDialog();
            this.Close();
        }
    }
}
