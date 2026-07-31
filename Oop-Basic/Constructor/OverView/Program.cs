using System;

namespace OverView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount acc = new BankAccount();
            //acc.Deposit(1000);
            //acc.Withdraw(300);
            //Console.WriteLine(acc.Balance);
            //acc.Balance= 100; //not accessible — direct field is private


            //Shape s1 = new Circle(4);
            //s1.Display();

            //Shape s2 = new Rectangle(4, 6);
            //s2.Display();

            Animal a1 = new Animal();
            a1.Name = "Jack";
            a1.Eat();
            a1.Bark();

            Console.ReadLine();
        }
    }
}
