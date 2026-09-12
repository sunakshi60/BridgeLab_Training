using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public sealed class LibraryCatalog
    {
        private static LibraryCatalog _instance;

        private LibraryCatalog()
        {
        }

        public static LibraryCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LibraryCatalog();
                }

                return _instance;
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Library Catalog is working.");
        }
    }
}
