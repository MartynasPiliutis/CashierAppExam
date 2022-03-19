using System.Collections.Generic;

namespace RestaurantCashier
{
    public class TablesRepository
    {
        public List<Tables> Tables;
        public TablesRepository()
        {
            Tables = new List<Tables>();
            object[,] tablesData = (object[,])FileService.FileReaderService(DataFiles.tablesFile);
            Tables = FileService.PopulateTablesList(tablesData);
        }

        public string GetTableNameByID(int tableId)
        {
            string tableToReturn = "";
            foreach (var item in Tables)
            {
                if (item.TableID == tableId)
                {
                    tableToReturn = item.TableName;
                }   
            }
            return tableToReturn;
        }

        public int GetSeatsByTableId(int tableId)
        {
            int seats = 0;
            foreach (var item in Tables)
            {
                if (item.TableID == tableId)
                {
                    seats = item.TableSeats;
                }
            }
            return seats;
        }
    }
}
