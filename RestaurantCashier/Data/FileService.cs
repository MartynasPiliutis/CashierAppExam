using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace RestaurantCashier
{
    public class FileService
    {
        public static object FileReaderService(string fileToRead)
        {
            List<string> listOfData = new();
            var fileReader = File.ReadAllLines(fileToRead);
            foreach (var item in fileReader)
            {
                listOfData.Add(item);
            }
            int splits = Convert.ToInt32(listOfData.ElementAt(0));
            listOfData.RemoveAt(1); //Remove expendable dataline
            listOfData.RemoveAt(0); //Remove expendable dataline
            int linesCount = listOfData.Count;
            var loadedData = new object[linesCount, splits];
            int lines = 0;

            foreach (var item in listOfData)
            {
                var split = item.Split(',');
                for (int i = 0; i < splits; i++)
                {
                    loadedData[lines, i] = split[i];
                }
                lines++;
            }
            return loadedData;
        }

#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        public static List<Tables> PopulateTablesList(object[,] array)
        {
            var tables = new List<Tables>();
            for (int i = 0; i < 8; i++)
            {
                int tableID = Convert.ToInt32(array[i, 0]);
                string tableName = Convert.ToString(array[i, 1]);
                int tableSeats = Convert.ToInt32(array[i, 2]);
                bool tableFree = Convert.ToBoolean(array[i, 3]);

                tables.Add(new Tables(tableID, tableName, tableSeats, tableFree));
            }
            return tables;
        }

        public static List<Menu> PopulateMenuList(object[,] array)
        {
            var menu = new List<Menu>();
            int listCount = array.GetLength(0);
            for (int i = 0; i < listCount; i++)
            {
                string menuName = Convert.ToString(array[i, 0]);
                int itemID = Convert.ToInt32(array[i, 1]);
                string itemName = Convert.ToString(array[i, 2]);
                int itemQuantity = Convert.ToInt32(array[i, 3]);
                string itemUnit = Convert.ToString(array[i, 4]);
                double itemPrice = Convert.ToDouble(array[i, 5]);

                menu.Add(new Menu(menuName, itemID, itemName, itemQuantity, itemUnit, itemPrice));
            }
            return menu;
        }
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    }
}
