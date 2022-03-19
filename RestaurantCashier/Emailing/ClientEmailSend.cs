using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class ClientEmailSend : ISendEmail
    {
        public string SendEmail(string email, string receiptName)
        {
            string confirmationSend = $"Receipt {receiptName} has been sent. Receiver: Client. Email address: {email}";
            return confirmationSend;
        }
    }
}
