using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class ListManager
    {
        public void AddElement(List<int> list,int element)
        {
            list.Add(element);
        }

        public void RemoveElement(List<int> list,int element)
        {
            list.Remove(element);
        }

        public int GetSize(List<int> list)
        {
            return list.Count;
        }
    }
}
