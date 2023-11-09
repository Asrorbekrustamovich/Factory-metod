using Factory_metod.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_metod.Classes
{
    public class PaypalPayment : IPayment
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"succesfully {amount} money is paid by Paypal");
        }
    }
}
