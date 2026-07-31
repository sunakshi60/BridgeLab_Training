using System;

namespace Level1
{
    class Person
    {
        string name;
        int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(Person p)
        {
            name = p.name;
            age = p.age;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}