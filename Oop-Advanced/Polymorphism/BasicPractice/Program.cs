using System;

namespace BasicPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();

            //Animal1 animal;
            //animal = new Dog1();
            //animal.Sound();
            //animal = new Cat1();
            //animal.Sound();

            //Animal2 animal = new Dog2();
            //animal.Eat();

            //Animal3 animal = new Dog3();
            //Dog3 dog = (Dog3)animal;
            //dog.Bark();

            //Animal4 animal = new Dog4();
            //animal.Sound();
            //Dog4 dog = new Dog4();
            //dog.Sound();

            //Animal5 animal = new Dog5();
            //animal.Sound();
            //animal.Eat();

            IPayment payment;
            payment = new CreditCard();
            payment.Pay();
            payment = new UPI();
            payment.Pay();
            payment = new NetBanking();
            payment.Pay();
            Console.ReadLine();
        }

    }
}
