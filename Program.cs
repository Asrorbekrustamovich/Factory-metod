using Factory_metod.Classes;
using Factory_metod.Interface;
using Factory_metod.enums;
namespace Factory_metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = PaymentFactory.Create(Paymentmethod.creditcard);
            payment.Pay(1000);

           
            
        }
    }
}