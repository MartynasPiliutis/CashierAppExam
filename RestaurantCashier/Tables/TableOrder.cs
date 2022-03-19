namespace RestaurantCashier
{
    public class TableOrder : Menu
    {
        public int TableID { get; set; }
        public int OrderID { get; set; }
        public int OrderQuantity { get; set; }
        public double TotalItemPrice { get; set; }
        public TableOrder
            (int tableId, int orderId, string orderMenu, int orderItemId, string orderItemName, int itemQuantity, int orderQuantity,
            string orderItemUnit, double orderUnitPrice, double totalItemPrice)
            : base(orderMenu, orderItemId, orderItemName, itemQuantity, orderItemUnit, orderUnitPrice)
        {
            TableID = tableId;
            OrderID = orderId;
            OrderQuantity = orderQuantity;
            TotalItemPrice = totalItemPrice;
        }
    }
}
