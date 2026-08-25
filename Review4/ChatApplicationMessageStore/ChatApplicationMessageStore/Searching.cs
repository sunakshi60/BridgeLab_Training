using System;
using System.Collections.Generic;
using System.Reflection;

namespace ChatApplicationMessageStore
{
    public class Searching
    {
        public static Contact BinarySearch(List<Contact> contacts, string name)
        {
            int left = 0;
            int right = contacts.Count - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int comparison =
                    string.Compare(
                        contacts[middle].Name,
                        name,
                        StringComparison.OrdinalIgnoreCase
                    );
                if (comparison == 0)
                {
                    return contacts[middle];
                }
                if (comparison < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return null;
        }
    }
}
