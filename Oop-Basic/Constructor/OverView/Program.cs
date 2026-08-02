using System;

namespace OverView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DogInheritance d = new DogInheritance();
            //d.Eat();
            //d.Bark();

            //BankAccount acc = new BankAccount();
            //acc.Deposit(1000);
            //acc.Withdraw(300);
            //Console.WriteLine(acc.Balance);
            ////acc.Balance = 100; //not accessible — direct field is private


            //Shape s1 = new Circle(4);
            //s1.Display();
            //Shape s2 = new Rectangle(4, 6);
            //s2.Display();

            //AnimalPoly a;
            ////a = new Dog();
            ////a = new Cat();
            //a = new AnimalPoly();
            //a.Sound();

            //Calculator c = new Calculator();
            //Console.WriteLine(c.Add(10, 20));
            //Console.WriteLine(c.Add(10.5, 20.5));

            // Default Constructor
            //StudentDefault s1 = new StudentDefault();
            //s1.Display();

            // Parameterized Constructor
            //StudentParameterized s2 = new StudentParameterized("Sunakshi", 21);
            //s2.Display();

            // Copy Constructor
            //StudentCopy s3 = new StudentCopy("Sunakshi", 21);
            //StudentCopy s4 = new StudentCopy(s3);
            //s3.Display();
            //s4.Display();

            // Static Constructor
            //StudentStatic st1 = new StudentStatic();
            //StudentStatic st2 = new StudentStatic();

            // Private Constructor
            Singleton.Show();


            Console.ReadLine();
        }
    }
}
