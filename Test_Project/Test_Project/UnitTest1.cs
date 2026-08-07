using NUnit.Framework;
using NUnit_Testing;

namespace TestProject1
{
    public class Tests
    {
        ////----------------------------------Calculator-----------------------------------
        //private Calculator calc;

        //[SetUp]
        //public void Setup()
        //{
        //    calc = new Calculator();
        //}

        //[Test]
        //public void Add_Two_Numbers()
        //{
        //    // Arrange
        //    int a = 5;
        //    int b = 3;
        //    int expected = 8;

        //    // Act
        //    int result = calc.Add(a, b);

        //    // Assert
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Subtract_Two_Numbers()
        //{
        //    // Arrange
        //    int a = 10;
        //    int b = 5;
        //    int expected = 5;

        //    // Act
        //    int result = calc.Subtract(a, b);

        //    // Assert
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Multiply_Two_Numbers()
        //{
        //    // Arrange
        //    int a = 5;
        //    int b = 3;
        //    int expected = 15;

        //    // Act
        //    int result = calc.Multiply(a, b);

        //    // Assert
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Divide_Two_Numbers()
        //{
        //    // Arrange
        //    int a = 20;
        //    int b = 5;
        //    int expected = 4;

        //    // Act
        //    int result = calc.Divide(a, b);

        //    // Assert
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Divide_By_Zero_Should_Throw_Exception()
        //{
        //    // Arrange
        //    int a = 5;
        //    int b = 0;

        //    // Act & Assert
        //    Assert.Throws<DivideByZeroException>(() => calc.Divide(a, b));
        //}

        ////--------------------------------------------Prime Number-----------------------------------------------
        //private PrimeNumber prime;

        //[SetUp]
        //public void Setup()
        //{
        //    prime = new PrimeNumber();
        //}

        //[Test]
        //public void IsPrime_WhenNumberIsPrime_ReturnsTrue()
        //{
        //    int number = 13;

        //    bool result = prime.IsPrime(number);

        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void IsPrime_WhenNumberIsNotPrime_ReturnsFalse()
        //{
        //    int number = 12;

        //    bool result = prime.IsPrime(number);

        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void IsPrime_WhenNumberIsOne_ReturnsFalse()
        //{
        //    int number = 1;

        //    bool result = prime.IsPrime(number);

        //    Assert.That(result, Is.False);
        //}

        ////------------------------------------------------String Utility Methods---------------------------------------------- 
        //private StringUtils utils;

        //[SetUp]
        //public void Setup()
        //{
        //    utils = new StringUtils();
        //}

        //[TestCase("hello", "olleh")]
        //[TestCase("madam", "madam")]
        //[TestCase("abc", "cba")]
        //public void Reverse_Test(string input, string expected)
        //{
        //    Assert.That(utils.Reverse(input), Is.EqualTo(expected));
        //}

        //[TestCase("madam", true)]
        //[TestCase("racecar", true)]
        //[TestCase("hello", false)]
        //public void IsPalindrome_Test(string input, bool expected)
        //{
        //    Assert.That(utils.IsPalindrome(input), Is.EqualTo(expected));
        //}

        //[TestCase("sakshi", "SAKSHI")]
        //[TestCase("dotnet", "DOTNET")]
        //public void ToUpperCase_Test(string input, string expected)
        //{
        //    Assert.That(utils.ToUpperCase(input), Is.EqualTo(expected));
        //}

        ////--------------------------------------------Testing List Operations-----------------------------------------------------------
        //private ListManager manager;

        //[SetUp]
        //public void Setup()
        //{
        //    manager = new ListManager();
        //}

        //[Test]
        //public void Add_Element_Test()
        //{
        //    List<int> list = new List<int>();
        //    manager.AddElement(list, 10);
        //    Assert.That(list.Contains(10), Is.True);
        //}

        //[Test]
        //public void Remove_Element_Test()
        //{
        //    List<int> list = new List<int>() { 10, 20, 30 };
        //    manager.RemoveElement(list, 20);
        //    Assert.That(list.Contains(20), Is.False);
        //}

        //[Test]
        //public void Get_Size_Test()
        //{
        //    List<int> list = new List<int>() { 10, 20, 30 };
        //    int expected = 3;
        //    int result = manager.GetSize(list);
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        ////---------------------------------------------------------Exception Handling---------------------------------------------------------
        //private ExceptionHandling obj;

        //[SetUp]
        //public void Setup()
        //{
        //    obj = new ExceptionHandling();
        //}

        //[Test]
        //public void Divide_Valid_Numbers()
        //{
        //    int a = 20;
        //    int b = 4;
        //    int expected = 5;
        //    int result = obj.Divide(a, b);
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Divide_By_Zero_Should_Throw_ArithmeticException()
        //{
        //    int a = 20;
        //    int b = 0;
        //    Assert.Throws<ArithmeticException>(() => obj.Divide(a, b));
        //}

        ////----------------------------------------------------Testing Setup and Teardown------------------------------------------------
        //private DatabaseConnection db;

        //[SetUp]
        //public void Setup()
        //{
        //    db = new DatabaseConnection();
        //    db.Connect();
        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    db.Disconnect();
        //}

        //[Test]
        //public void Database_Should_Be_Connected()
        //{
        //    Assert.That(db.IsConnected, Is.True);
        //}

        //[Test]
        //public void Database_Should_Be_Disconnected()
        //{
        //    db.Disconnect();
        //    Assert.That(db.IsConnected, Is.False);
        //}


        ////---------------------------------------------------------Even Number---------------------------------------------------
        //private EvenNumber even;

        //[SetUp]
        //public void Setup()
        //{
        //    even = new EvenNumber();
        //}

        //[TestCase(2, true)]
        //[TestCase(4, true)]
        //[TestCase(6, true)]
        //[TestCase(7, false)]
        //[TestCase(9, false)]
        //public void IsEven_Test(int number, bool expected)
        //{
        //    bool result = even.IsEven(number);
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        ////-------------------------------------------Performance Testing Using Timeout---------------------------------------------------
        //private Performance performance;

        //[SetUp]
        //public void Setup()
        //{
        //    performance = new Performance();
        //}

        //[Test]
        //[Timeout(2000)]
        //public void LongRunningTask_Should_Complete_Within_2_Seconds()
        //{
        //    string result = performance.LongRunningTask();
        //    Assert.That(result, Is.EqualTo("Task Completed"));
        //}


        ////------------------------------------------------Testing File Handling Methods-----------------------------------------------
        //private FileProcessor fileProcessor;
        //private string fileName;

        //[SetUp]
        //public void Setup()
        //{
        //    fileProcessor = new FileProcessor();
        //    fileName = "TestFile.txt";
        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    if (File.Exists(fileName))
        //    {
        //        File.Delete(fileName);
        //    }
        //}

        //[Test]
        //public void Write_And_Read_File_Test()
        //{
        //    string expected = "Hello NUnit";
        //    fileProcessor.WriteToFile(fileName, expected);
        //    string result = fileProcessor.ReadFromFile(fileName);
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void File_Should_Exist_After_Writing()
        //{
        //    string content = "Hello";
        //    fileProcessor.WriteToFile(fileName, content);
        //    Assert.That(File.Exists(fileName), Is.True);
        //}

        //[Test]
        //public void Read_Non_Existing_File_Should_Throw_IOException()
        //{
        //    string invalidFile = "Unknown.txt";
        //    Assert.That(() => fileProcessor.ReadFromFile(invalidFile),
        //        Throws.TypeOf<IOException>());
        //}


        ////-------------------------------------Testing Banking Transactions-------------------------
        //private BankAccount account;

        //[SetUp]
        //public void Setup()
        //{
        //    account = new BankAccount();
        //}

        //[Test]
        //public void Deposit_Test()
        //{
        //    double amount = 5000;
        //    double expected = 5000;
        //    account.Deposit(amount);
        //    double result = account.GetBalance();
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Withdraw_Test()
        //{
        //    account.Deposit(5000);
        //    double withdrawAmount = 2000;
        //    double expected = 3000;
        //    account.Withdraw(withdrawAmount);
        //    double result = account.GetBalance();
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Withdraw_With_Insufficient_Balance_Should_Throw_Exception()
        //{
        //    account.Deposit(1000);
        //    Assert.That(() => account.Withdraw(2000),
        //        Throws.TypeOf<InvalidOperationException>());
        //}


        ////--------------------------------------------------Testing Password Strength Validator-------------------------------------------
        //private PasswordValidator validator;

        //[SetUp]
        //public void Setup()
        //{
        //    validator = new PasswordValidator();
        //}

        //[Test]
        //public void Valid_Password_Test()
        //{
        //    string password = "Password1";
        //    bool result = validator.ValidatePassword(password);
        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void Password_With_Less_Than_8_Characters_Should_Return_False()
        //{
        //    string password = "Pass1";
        //    bool result = validator.ValidatePassword(password);
        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Password_Without_Uppercase_Should_Return_False()
        //{
        //    string password = "password1";
        //    bool result = validator.ValidatePassword(password);
        //    Assert.That(result, Is.False);
        //}

        //[Test]
        //public void Password_Without_Digit_Should_Return_False()
        //{
        //    string password = "Password";
        //    bool result = validator.ValidatePassword(password);
        //    Assert.That(result, Is.False);
        //}

        ////-------------------------------------------------Testing Date Formatter----------------------------------------------------
        //private TemperatureConverter converter;

        //[SetUp]
        //public void Setup()
        //{
        //    converter = new TemperatureConverter();
        //}

        //[Test]
        //public void Celsius_To_Fahrenheit_Test()
        //{
        //    double celsius = 25;
        //    double expected = 77;
        //    double result = converter.CelsiusToFahrenheit(celsius);
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        //[Test]
        //public void Fahrenheit_To_Celsius_Test()
        //{
        //    double fahrenheit = 98.6;
        //    double expected = 37;
        //    double result = converter.FahrenheitToCelsius(fahrenheit);
        //    Assert.That(result, Is.EqualTo(expected).Within(0.1));
        //}

        ////--------------------------------------------------Testing User Registration-------------------------------------------------
        //private UserRegistration user;

        //[SetUp]
        //public void Setup()
        //{
        //    user = new UserRegistration();
        //}

        //[Test]
        //public void Register_Valid_User()
        //{
        //    string username = "Sakshi";
        //    string email = "sakshi@gmail.com";
        //    string password = "Password123";
        //    string result = user.RegisterUser(username, email, password);
        //    Assert.That(result, Is.EqualTo("User Registered Successfully"));
        //}

        //[Test]
        //public void Register_Invalid_Username_Should_Throw_Exception()
        //{
        //    Assert.That(() => user.RegisterUser("", "sakshi@gmail.com", "Password123"),
        //        Throws.TypeOf<ArgumentException>());
        //}

        //[Test]
        //public void Register_Invalid_Email_Should_Throw_Exception()
        //{
        //    Assert.That(() => user.RegisterUser("Sakshi", "sakshigmail.com", "Password123"),
        //        Throws.TypeOf<ArgumentException>());
        //}

        //[Test]
        //public void Register_Invalid_Password_Should_Throw_Exception()
        //{
        //    Assert.That(() => user.RegisterUser("Sakshi", "sakshi@gmail.com", "Pass1"),
        //        Throws.TypeOf<ArgumentException>());
        //}


        ////--------------------------------------------------Testing Date Formatter----------------------------------------------------
        private DateFormatter formatter;

        [SetUp]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [Test]
        public void Format_Valid_Date()
        {
            string input = "2026-08-07";
            string expected = "07-08-2026";
            string result = formatter.FormatDate(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Format_Invalid_Date_Should_Throw_Exception()
        {
            string input = "07/08/2026";
            Assert.That(() => formatter.FormatDate(input),
                Throws.TypeOf<FormatException>());
        }
    }
}