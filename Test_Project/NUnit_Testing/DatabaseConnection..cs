using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            IsConnected = true;
            Console.WriteLine("Database Connected");
        }
        public void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("Database Disconnected");
        }
    }
}
