using ValidateRegex;

namespace RegexTestProject
{
    public class Tests
    {

        ////-------------------------------------Validate a Username-----------------------------
        //private UserNameValidator validator;

        //[SetUp]
        //public void Setup()
        //{
        //    validator = new UserNameValidator();
        //}

        //[Test]
        //public void Valid_Username_Test()
        //{
        //    string username = "user_123";
        //    bool result = validator.ValidateUsername(username);
        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void Username_Starting_With_Number_Should_Return_False()
        //{
        //    string username = "123user";
        //    bool result = validator.ValidateUsername(username);
        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Username_Too_Short_Should_Return_False()
        //{
        //    string username = "us";
        //    bool result = validator.ValidateUsername(username);
        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Username_With_Special_Character_Should_Return_False()
        //{
        //    string username = "user@123";
        //    bool result = validator.ValidateUsername(username);
        //    Assert.That(result, Is.False);
        //}

        ////--------------------------------Validate a License Plate Number--------------------------------------
        //private LicensePlateValidator validator;

        //[SetUp]
        //public void Setup()
        //{
        //    validator = new LicensePlateValidator();
        //}

        //[Test]
        //public void Valid_License_Plate_Test()
        //{
        //    string plate = "AB1234";
        //    bool result = validator.ValidateLicensePlate(plate);
        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void License_Plate_With_One_Letter_Should_Return_False()
        //{
        //    string plate = "A12345";
        //    bool result = validator.ValidateLicensePlate(plate);
        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void License_Plate_With_Lowercase_Should_Return_False()
        //{
        //    string plate = "ab1234";
        //    bool result = validator.ValidateLicensePlate(plate);
        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void License_Plate_With_Invalid_Length_Should_Return_False()
        //{
        //    string plate = "AB123";
        //    bool result = validator.ValidateLicensePlate(plate);
        //    Assert.That(result, Is.False);
        //}

        ////--------------------------------------Validate a Hex Color Code-------------------------------------
        //private HexColorValidator validator;

        //[SetUp]
        //public void Setup()
        //{
        //    validator = new HexColorValidator();
        //}

        //[Test]
        //public void Valid_Hex_Color_UpperCase_Test()
        //{
        //    string color = "#FFA500";
        //    bool result = validator.ValidateHexColor(color);
        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void Valid_Hex_Color_LowerCase_Test()
        //{
        //    string color = "#ff4500";
        //    bool result = validator.ValidateHexColor(color);
        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void Short_Hex_Color_Should_Return_False()
        //{
        //    string color = "#123";
        //    bool result = validator.ValidateHexColor(color);
        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Hex_Color_Without_Hash_Should_Return_False()
        //{
        //    string color = "FFA500";
        //    bool result = validator.ValidateHexColor(color);
        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Invalid_Hex_Characters_Should_Return_False()
        //{
        //    string color = "#ZZZZZZ";
        //    bool result = validator.ValidateHexColor(color);
        //    Assert.That(result, Is.False);
        //}


        ////----------------------------Extract All Email Addresses from a Tex----------------------------------
        //private EmailExtractor extractor;

        //[SetUp]
        //public void Setup()
        //{
        //    extractor = new EmailExtractor();
        //}

        //[Test]
        //public void Extract_Email_Addresses_Test()
        //{
        //    string text = "Contact us at support@example.com and info@company.org";
        //    List<string> result = extractor.ExtractEmails(text);
        //    Assert.That(result.Count, Is.EqualTo(2));
        //    Assert.That(result[0], Is.EqualTo("support@example.com"));
        //    Assert.That(result[1], Is.EqualTo("info@company.org"));
        //}

        //[Test]
        //public void No_Email_Should_Return_Empty_List()
        //{
        //    string text = "Hello World";
        //    List<string> result = extractor.ExtractEmails(text);
        //    Assert.That(result.Count, Is.EqualTo(0));
        //}


        ////----------------------------------Extract All Capitalized Words from a Sentence---------------------------
        //private CapitalizedWordExtractor extractor;

        //[SetUp]
        //public void Setup()
        //{
        //    extractor = new CapitalizedWordExtractor();
        //}

        //[Test]
        //public void Extract_Capitalized_Words_Test()
        //{
        //    string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        //    List<string> result = extractor.ExtractCapitalizedWords(text);
        //    Assert.That(result.Contains("Eiffel"), Is.True);
        //    Assert.That(result.Contains("Tower"), Is.True);
        //    Assert.That(result.Contains("Paris"), Is.True);
        //    Assert.That(result.Contains("Statue"), Is.True);
        //    Assert.That(result.Contains("Liberty"), Is.True);
        //    Assert.That(result.Contains("New"), Is.True);
        //    Assert.That(result.Contains("York"), Is.True);
        //}

        //[Test]
        //public void No_Capitalized_Words_Should_Return_Empty_List()
        //{
        //    string text = "this is a simple sentence.";
        //    List<string> result = extractor.ExtractCapitalizedWords(text);
        //    Assert.That(result.Count, Is.EqualTo(0));
        //}

        ////------------------------------Extract Dates in dd/mm/yyyy Format------------------------------
        //private DateExtractor extractor;

        //[SetUp]
        //public void Setup()
        //{
        //    extractor = new DateExtractor();
        //}

        //[Test]
        //public void Extract_Dates_Test()
        //{
        //    string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

        //    List<string> result = extractor.ExtractDates(text);

        //    Assert.That(result.Count, Is.EqualTo(3));
        //    Assert.That(result[0], Is.EqualTo("12/05/2023"));
        //    Assert.That(result[1], Is.EqualTo("15/08/2024"));
        //    Assert.That(result[2], Is.EqualTo("29/02/2020"));
        //}

        //[Test]
        //public void No_Dates_Should_Return_Empty_List()
        //{
        //    string text = "There are no dates in this sentence.";

        //    List<string> result = extractor.ExtractDates(text);

        //    Assert.That(result.Count, Is.EqualTo(0));
        //}


        ////-------------------------------------Extract Links from a Web Page------------------------------------
        //private LinkExtractor extractor;

        //[SetUp]
        //public void Setup()
        //{
        //    extractor = new LinkExtractor();
        //}

        //[Test]
        //public void Extract_Links_Test()
        //{
        //    string text = "Visit https://www.google.com and http://example.org for more info.";

        //    List<string> result = extractor.ExtractLinks(text);

        //    Assert.That(result.Count, Is.EqualTo(2));
        //    Assert.That(result[0], Is.EqualTo("https://www.google.com"));
        //    Assert.That(result[1], Is.EqualTo("http://example.org"));
        //}

        //[Test]
        //public void No_Links_Should_Return_Empty_List()
        //{
        //    string text = "There are no links here.";

        //    List<string> result = extractor.ExtractLinks(text);

        //    Assert.That(result.Count, Is.EqualTo(0));
        //}

        ////----------------------------Replace Multiple Spaces with a Single Space-------------------------
        //private SpaceReplacer replacer;

        //[SetUp]
        //public void Setup()
        //{
        //    replacer = new SpaceReplacer();
        //}

        //[Test]
        //public void Replace_Multiple_Spaces_Test()
        //{
        //    string input = "This     is      an      example.";
        //    string expected = "This is an example.";

        //    string result = replacer.ReplaceMultipleSpaces(input);

        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Single_Spaces_Should_Remain_Unchanged()
        //{
        //    string input = "Hello World";
        //    string expected = "Hello World";

        //    string result = replacer.ReplaceMultipleSpaces(input);

        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Empty_String_Test()
        //{
        //    string input = "";
        //    string expected = "";

        //    string result = replacer.ReplaceMultipleSpaces(input);

        //    Assert.That(result, Is.EqualTo(expected));
        //}


        ////---------------------------------Censor Bad Words in a Sentence-------------------------------
        //private BadWordCensor censor;

        //[SetUp]
        //public void Setup()
        //{
        //    censor = new BadWordCensor();
        //}

        //[Test]
        //public void Replace_Bad_Words_Test()
        //{
        //    string input = "This is a damn bad example with some stupid words.";
        //    string expected = "This is a **** bad example with some **** words.";

        //    string result = censor.CensorBadWords(input);

        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Ignore_Case_Test()
        //{
        //    string input = "DAMN and Stupid";
        //    string expected = "**** and ****";

        //    string result = censor.CensorBadWords(input);

        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void No_Bad_Words_Should_Return_Same_String()
        //{
        //    string input = "This is a good sentence.";
        //    string expected = "This is a good sentence.";

        //    string result = censor.CensorBadWords(input);

        //    Assert.That(result, Is.EqualTo(expected));
        //}


        ////----------------------------Validate an IP Address-------------------------------------
        //private IPAddressValidator validator;

        //[SetUp]
        //public void Setup()
        //{
        //    validator = new IPAddressValidator();
        //}

        //[Test]
        //public void Valid_IP_Address_Test()
        //{
        //    string ip = "192.168.1.1";

        //    bool result = validator.ValidateIPAddress(ip);

        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void Maximum_IP_Address_Test()
        //{
        //    string ip = "255.255.255.255";

        //    bool result = validator.ValidateIPAddress(ip);

        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void Invalid_IP_Address_Over_255_Should_Return_False()
        //{
        //    string ip = "256.100.50.25";

        //    bool result = validator.ValidateIPAddress(ip);

        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Invalid_IP_Address_With_Three_Groups_Should_Return_False()
        //{
        //    string ip = "192.168.1";

        //    bool result = validator.ValidateIPAddress(ip);

        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Invalid_IP_Address_With_Five_Groups_Should_Return_False()
        //{
        //    string ip = "192.168.1.1.5";

        //    bool result = validator.ValidateIPAddress(ip);

        //    Assert.That(result, Is.False);
        //}


        ////---------------------------Validate a Credit Card Number (Visa, MasterCard, etc.)-----------------
        //private CreditCardValidator validator;

        //[SetUp]
        //public void Setup()
        //{
        //    validator = new CreditCardValidator();
        //}

        //[Test]
        //public void Valid_Visa_Card_Test()
        //{
        //    string card = "4123456789012345";

        //    bool result = validator.ValidateCard(card);

        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void Valid_MasterCard_Test()
        //{
        //    string card = "5123456789012345";

        //    bool result = validator.ValidateCard(card);

        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void Invalid_Starting_Digit_Should_Return_False()
        //{
        //    string card = "6123456789012345";

        //    bool result = validator.ValidateCard(card);

        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Invalid_Length_Should_Return_False()
        //{
        //    string card = "41234567890";

        //    bool result = validator.ValidateCard(card);

        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Card_With_Characters_Should_Return_False()
        //{
        //    string card = "41234ABCDE12345";

        //    bool result = validator.ValidateCard(card);

        //    Assert.That(result, Is.False);
        //}

        ////------------------------------Extract Programming Language Names from a Text------------------------------------------
        //private ProgrammingLanguageExtractor extractor;

        //[SetUp]
        //public void Setup()
        //{
        //    extractor = new ProgrammingLanguageExtractor();
        //}

        //[Test]
        //public void Extract_Programming_Languages_Test()
        //{
        //    string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        //    List<string> result = extractor.ExtractLanguages(text);
        //    Assert.That(result.Count, Is.EqualTo(4));
        //    Assert.That(result[0], Is.EqualTo("Java"));
        //    Assert.That(result[1], Is.EqualTo("Python"));
        //    Assert.That(result[2], Is.EqualTo("JavaScript"));
        //    Assert.That(result[3], Is.EqualTo("Go"));
        //}

        //[Test]
        //public void No_Programming_Language_Should_Return_Empty_List()
        //{
        //    string text = "I love coding and software development.";
        //    List<string> result = extractor.ExtractLanguages(text);
        //    Assert.That(result.Count, Is.EqualTo(0));
        //}

        //[Test]
        //public void Language_Extraction_Should_Ignore_Case()
        //{
        //    string text = "I know JAVA and python.";
        //    List<string> result = extractor.ExtractLanguages(text);
        //    Assert.That(result.Count, Is.EqualTo(2));
        //}


        ////--------------------------------------Extract Currency Values from a Text-----------------------------------------------
        //private CurrencyExtractor extractor;

        //[SetUp]
        //public void Setup()
        //{
        //    extractor = new CurrencyExtractor();
        //}

        //[Test]
        //public void Extract_Currency_Values_Test()
        //{
        //    string text = "The price is $45.99, and the discount is $ 10.50.";
        //    List<string> result = extractor.ExtractCurrencyValues(text);
        //    Assert.That(result.Count, Is.EqualTo(2));
        //    Assert.That(result[0], Is.EqualTo("$45.99"));
        //    Assert.That(result[1], Is.EqualTo("10.50"));
        //}

        //[Test]
        //public void Extract_Single_Currency_Value_Test()
        //{
        //    string text = "The price is $100.00.";
        //    List<string> result = extractor.ExtractCurrencyValues(text);
        //    Assert.That(result.Count, Is.EqualTo(1));
        //    Assert.That(result[0], Is.EqualTo("$100.00"));
        //}

        //[Test]
        //public void No_Currency_Should_Return_Empty_List()
        //{
        //    string text = "The product is expensive.";
        //    List<string> result = extractor.ExtractCurrencyValues(text);
        //    Assert.That(result.Count, Is.EqualTo(0));
        //}


        ////--------------------------------Find Repeating Words in a Sentence----------------------------------------------
        //private RepeatingWordFinder finder;

        //[SetUp]
        //public void Setup()
        //{
        //    finder = new RepeatingWordFinder();
        //}

        //[Test]
        //public void Find_Repeating_Words_Test()
        //{
        //    string text = "This is is a repeated repeated word test.";
        //    List<string> result = finder.FindRepeatingWords(text);
        //    Assert.That(result.Count, Is.EqualTo(2));
        //    Assert.That(result[0], Is.EqualTo("is"));
        //    Assert.That(result[1], Is.EqualTo("repeated"));
        //}

        //[Test]
        //public void No_Repeating_Words_Should_Return_Empty_List()
        //{
        //    string text = "This is a simple sentence.";
        //    List<string> result = finder.FindRepeatingWords(text);
        //    Assert.That(result.Count, Is.EqualTo(0));
        //}

        //[Test]
        //public void Repeating_Words_Should_Ignore_Case()
        //{
        //    string text = "This is IS a test.";
        //    List<string> result = finder.FindRepeatingWords(text);
        //    Assert.That(result.Count, Is.EqualTo(1));
        //    Assert.That(result[0], Is.EqualTo("is"));
        //}


        ////----------------------------------Validate a Social Security Number (SSN)------------------------------------------
        private SSNValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new SSNValidator();
        }

        [Test]
        public void Valid_SSN_Test()
        {
            string ssn = "123-45-6789";
            bool result = validator.ValidateSSN(ssn);
            Assert.That(result, Is.True);
        }

        [Test]
        public void SSN_Without_Hyphens_Should_Be_Invalid()
        {
            string ssn = "123456789";
            bool result = validator.ValidateSSN(ssn);
            Assert.That(result, Is.False);
        }

        [Test]
        public void SSN_With_Wrong_Format_Should_Be_Invalid()
        {
            string ssn = "12-345-6789";
            bool result = validator.ValidateSSN(ssn);
            Assert.That(result, Is.False);
        }

        [Test]
        public void SSN_With_Letters_Should_Be_Invalid()
        {
            string ssn = "ABC-45-6789";
            bool result = validator.ValidateSSN(ssn);
            Assert.That(result, Is.False);
        }

    }
}
