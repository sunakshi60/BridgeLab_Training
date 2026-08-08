using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateRegex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UserNameValidator validator = new UserNameValidator();
            //Console.Write("Enter Username: ");
            //string username = Console.ReadLine();
            //if (validator.ValidateUsername(username))
            //{
            //    Console.WriteLine("Valid Username");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Username");
            //}


            //LicensePlateValidator validator = new LicensePlateValidator();
            //Console.Write("Enter License Plate: ");
            //string plate = Console.ReadLine();
            //if (validator.ValidateLicensePlate(plate))
            //{
            //    Console.WriteLine("Valid License Plate");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid License Plate");
            //}


            //HexColorValidator validator = new HexColorValidator();
            //Console.Write("Enter Hex Color: ");
            //string color = Console.ReadLine();
            //if (validator.ValidateHexColor(color))
            //{
            //    Console.WriteLine("Valid Hex Color");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Hex Color");
            //}


            //EmailExtractor extractor = new EmailExtractor();
            //Console.Write("Enter Text: ");
            //string text = Console.ReadLine();
            //List<string> emails = extractor.ExtractEmails(text);
            //Console.WriteLine("\nExtracted Emails:");
            //foreach (string email in emails)
            //{
            //    Console.WriteLine(email);
            //}


            //CapitalizedWordExtractor extractor = new CapitalizedWordExtractor();
            //Console.Write("Enter Sentence: ");
            //string text = Console.ReadLine();
            //List<string> words = extractor.ExtractCapitalizedWords(text);
            //Console.WriteLine("\nCapitalized Words:");
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}


            //DateExtractor extractor = new DateExtractor();
            //Console.Write("Enter Text: ");
            //string text = Console.ReadLine();
            //List<string> dates = extractor.ExtractDates(text);
            //Console.WriteLine("\nExtracted Dates:");
            //foreach (string date in dates)
            //{
            //    Console.WriteLine(date);
            //}


            //LinkExtractor extractor = new LinkExtractor();
            //Console.Write("Enter Text: ");
            //string text = Console.ReadLine();
            //List<string> links = extractor.ExtractLinks(text);
            //Console.WriteLine("\nExtracted Links:");
            //foreach (string link in links)
            //{
            //    Console.WriteLine(link);
            //}


            //SpaceReplacer replacer = new SpaceReplacer();
            //Console.Write("Enter Text: ");
            //string text = Console.ReadLine();
            //string result = replacer.ReplaceMultipleSpaces(text);
            //Console.WriteLine("\nAfter Replacing:");
            //Console.WriteLine(result);


            //BadWordCensor censor = new BadWordCensor();
            //Console.Write("Enter Sentence: ");
            //string text = Console.ReadLine();
            //string result = censor.CensorBadWords(text);
            //Console.WriteLine("\nAfter Censoring:");
            //Console.WriteLine(result);


            //IPAddressValidator validator = new IPAddressValidator();
            //Console.Write("Enter IP Address: ");
            //string ip = Console.ReadLine();
            //if (validator.ValidateIPAddress(ip))
            //{
            //    Console.WriteLine("Valid IP Address");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid IP Address");
            //}

            //CreditCardValidator validator = new CreditCardValidator();
            //Console.Write("Enter Card Number: ");
            //string card = Console.ReadLine();
            //if (validator.ValidateCard(card))
            //{
            //    Console.WriteLine("Valid Credit Card");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Credit Card");
            //}


            //ProgrammingLanguageExtractor extractor =new ProgrammingLanguageExtractor();
            //Console.Write("Enter Text: ");
            //string text = Console.ReadLine();
            //List<string> languages = extractor.ExtractLanguages(text);
            //Console.WriteLine("\nProgramming Languages:");
            //foreach (string language in languages)
            //{
            //    Console.WriteLine(language);
            //}


            //CurrencyExtractor extractor = new CurrencyExtractor();
            //Console.Write("Enter Text: ");
            //string text = Console.ReadLine();
            //List<string> values = extractor.ExtractCurrencyValues(text);
            //Console.WriteLine("\nCurrency Values:");
            //foreach (string value in values)
            //{
            //    Console.WriteLine(value);
            //}

            //RepeatingWordFinder finder = new RepeatingWordFinder();
            //Console.Write("Enter Sentence: ");
            //string text = Console.ReadLine();
            //List<string> words = finder.FindRepeatingWords(text);
            //Console.WriteLine("\nRepeating Words:");
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}


            SSNValidator validator = new SSNValidator();
            Console.Write("Enter SSN: ");
            string ssn = Console.ReadLine();
            if (validator.ValidateSSN(ssn))
            {
                Console.WriteLine("Valid SSN");
            }
            else
            {
                Console.WriteLine("Invalid SSN");
            }
        }
    }
}
