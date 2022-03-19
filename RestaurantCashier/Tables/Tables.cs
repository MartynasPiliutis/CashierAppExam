using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class Tables
    {
        public int TableID { get; private set; }
        public string TableName { get; private set; }
        public int TableSeats { get; private set; }
        public bool TableFree { get; set; }

        public Tables(int tableID, string tableName, int tableSeats, bool tableFree)
        {
            TableID = tableID;
            TableName = tableName;
            TableSeats = tableSeats;
            TableFree = tableFree;
        }
    }
}
