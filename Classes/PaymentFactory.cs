using Factory_metod.enums;
using Factory_metod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_metod.Classes
{
    public class PaymentFactory
    {
        public static IPayment Create(Paymentmethod paymentmethod)
        {
            switch(paymentmethod)
            {
                case Paymentmethod.creditcard:
                    return new CreaditCarPayment();break;
                case Paymentmethod.paypal:return new PaypalPayment();break;
                case Paymentmethod.google:return new Googlepayment();break;
                default:throw new NotSupportedException($"{paymentmethod}is not supported now");
            }
        }
    }
}
