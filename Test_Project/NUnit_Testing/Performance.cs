using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class Performance
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000);     // Wait for 3 seconds
            return "Task Completed";
        }
    }
}
