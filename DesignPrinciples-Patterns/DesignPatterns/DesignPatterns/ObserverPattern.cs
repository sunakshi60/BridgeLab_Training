using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    //Observer Interface
    public interface IObserver
    {
        void Update(string message);
    }

    //Concrete Observer
    public class UserObserver : IObserver 
    {
        private string _name;
        
        public UserObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} notified: {message}");
        } 
    }

    //Subject
    public class BookCatalog
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NewBookArrived(string bookName)
        {
            NotifyAllObservers($"New book available: {bookName}");
        }

        private void NotifyAllObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}