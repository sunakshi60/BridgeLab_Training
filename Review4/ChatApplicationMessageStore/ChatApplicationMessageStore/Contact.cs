using System;
using System.Collections.Generic;


namespace ChatApplicationMessageStore
{
    public class Contact
    {
        public string Name;
        public int ContactId;
        public Contact(int id ,string name)
        {       
            this.ContactId = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return ContactId + " - " + Name;
        }
    }
}
