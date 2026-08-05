using System;

namespace BasicPractice
{
    interface IPayment
    {
        void Pay();
    }
    class CreditCard : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Credit Card Payment");
        }
    }
    class UPI : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("UPI Payment");
        }
    }
    class NetBanking : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Net Banking Payment");
        }
    }
}