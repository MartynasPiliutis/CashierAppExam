using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCashier
{
    public interface ISendEmail
    {
        string SendEmail(string email, string receiptName);
    }
}
