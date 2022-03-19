using System;
using System.Collections.Generic;
using System.IO;

namespace RestaurantCashier
{
    public class ReceiptsSavePrint
    {
        public void SaveReceiptToFile(int currentOrderId, string tableName, List<TableOrder> currentTableOrder, int clientPrintTrigger)
        {
            int tableId = Program.orderRepository.GetTableIdFromOrdersList(currentOrderId);
            string dataFilePathClient = DataFiles.clientReceptsData;
            string dataFilePathRestaurant = DataFiles.restaurantReceptsData;
            string filenameClient = currentOrderId.ToString();
            string filenameRestaurant = currentOrderId.ToString();
            filenameClient = filenameClient +"-client" + ".txt";
            filenameRestaurant = filenameRestaurant + "-restaurant" + ".txt";
            string pathClient = dataFilePathClient + filenameClient;
            string pathRetaurant = dataFilePathRestaurant + filenameRestaurant;
            FileStream fsc = new FileStream(pathClient, FileMode.Create);
            FileStream fsr = new FileStream(pathRetaurant, FileMode.Create);
            TextWriter tmpTxt = Console.Out;
            StreamWriter swc = new StreamWriter(fsc);
            Console.SetOut(swc);
            List<string> clientReceipt = Program.orderDelivery.GenerateClientReceipt(tableName, currentOrderId, currentTableOrder);
            foreach (var item in clientReceipt)
            {
                Console.WriteLine(item);
            }
            Console.SetOut(tmpTxt);
            swc.Close();
            StreamWriter swr = new StreamWriter(fsr);
            Console.SetOut(swr);
            List<string> restaurantReceipt = Program.orderDelivery.GenerateRestaurantReceipt(tableName, currentOrderId, tableId, currentTableOrder);
            foreach (var item in restaurantReceipt)
            {
                Console.WriteLine(item);
            }
            Console.SetOut(tmpTxt);
            swr.Close();
            if (clientPrintTrigger == 1)
            {
                PrintReceipt(restaurantReceipt, 0);
                PrintReceipt(clientReceipt, 1);
            }
            else
            {
                PrintReceipt(restaurantReceipt, 0);
            }
        }

        public void PrintReceipt(List<string> receiptToPrint, int trigerClientPrint)
        {
            List<string> cutter = Program.orderDelivery.ReceiptPrintCutterLine();
            string printerFile = trigerClientPrint == 1 ? DataFiles.receiptPrinterClient : DataFiles.receiptPrinterRestaurant;
            File.AppendAllLines(printerFile, receiptToPrint);
            File.AppendAllLines(printerFile, cutter);
        }

    }
}
