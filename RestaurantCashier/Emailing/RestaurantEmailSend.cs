using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public class RestaurantEmailSend : ISendEmail
    {
        public string SendEmail(string email, string receiptName)
        {
            string confirmationSend = $"Receipt {receiptName} has been sent. Receiver: Restaurant Office. Email address: {email}";
            return confirmationSend;
        }
    }
}
