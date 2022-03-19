using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class TableOrderRepository
    {
        public List<TableOrder> table01Order = new();
        public List<TableOrder> table02Order = new();
        public List<TableOrder> table03Order = new();
        public List<TableOrder> table04Order = new();
        public List<TableOrder> table05Order = new();
        public List<TableOrder> table06Order = new();
        public List<TableOrder> table07Order = new();
        public List<TableOrder> table08Order = new();

        public void ClearTableOrder(List<TableOrder> listToClear)
        {
            foreach (var item in listToClear)
            {
                listToClear.Remove(item);
            }
        }
    }

}
