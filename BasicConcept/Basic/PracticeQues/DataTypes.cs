using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class DataTypes
    {
        public static void ShowDataTypes()
        {
            // Integer Data Types
            byte byteValue = 255;
            short shortValue = 32000;
            int intValue = 100000;
            long longValue = 9876543210;

            // Floating Point Data Types
            float floatValue = 12.5f;
            double doubleValue = 12345.6789;
            decimal decimalValue = 5000.75m;

            // Character and Boolean
            char grade = 'A';
            bool isPassed = true;

            // String
            string name = "Sakshi";

            Console.WriteLine("===== DATA TYPES =====");

            Console.WriteLine($"Byte : {byteValue}");
            Console.WriteLine($"Short : {shortValue}");
            Console.WriteLine($"Int : {intValue}");
            Console.WriteLine($"Long : {longValue}");
            Console.WriteLine($"Float : {floatValue}");
            Console.WriteLine($"Double : {doubleValue}");
            Console.WriteLine($"Decimal : {decimalValue}");
            Console.WriteLine($"Char : {grade}");
            Console.WriteLine($"Boolean : {isPassed}");
            Console.WriteLine($"String : {name}");
        }
    }
}
