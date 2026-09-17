using DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        //-------Singleton Pattern---------
        //LibraryCatalog catalog1 = LibraryCatalog.Instance;
        //LibraryCatalog catalog2 = LibraryCatalog.Instance;
        //catalog1.ShowMessage();
        //Console.WriteLine(catalog1 == catalog2);


        //--------FactoryMethod Pattern--------
        //ReportCreator creator;
        //creator = new PDFReportCreator();
        //creator.GenerateReport();
        //creator = new ExcelReportCreator();
        //creator.GenerateReport();
        //creator = new WordReportCreator();
        //creator.GenerateReport();


        //------AbstractFactory Pattern------
        //IVehicleFactory factory;
        //factory = new RegularVehicleFactory();
        //IBike bike = factory.CreateBike();
        //ICar car = factory.CreateCar();
        //bike.GetDetails();
        //car.GetDetails();
        //factory = new SportsVehicleFactory();
        //bike = factory.CreateBike();
        //car = factory.CreateCar();
        //bike.GetDetails();
        //car.GetDetails();

        //-----Adapter Pattern--------
        // string[,] employeesArray =
        //{
        //     { "101", "John", "SE", "10000" },
        //     { "102", "Smith", "SE", "20000" },
        //     { "103", "Dev", "SSE", "30000" },
        //     { "104", "Pam", "SE", "40000" },
        //     { "105", "Sara", "SSE", "50000" }
        // };
        // ITarget target = new EmployeeAdapter();
        // target.ProcessCompanySalary(employeesArray);

        //------Facade Pattern------
        //Order order = new Order();
        //order.PlaceOrder();


        //-----Command Pattern-----
        //Document document = new Document();
        //ICommand openCommand = new OpenCommand(document);
        //ICommand saveCommand = new SaveCommand(document);
        //ICommand closeCommand = new CloseCommand(document);
        //MenuOptions menu = new MenuOptions(
        //    openCommand,
        //    saveCommand,
        //    closeCommand
        //);
        //menu.ClickOpen();
        //menu.ClickSave();
        //menu.ClickClose();


        //----Observer Pattern----
        BookCatalog catalog = new BookCatalog();
        UserObserver user1 = new UserObserver("Amit");
        UserObserver user2 = new UserObserver("Neha");
        catalog.AddObserver(user1);
        catalog.AddObserver(user2);
        catalog.NewBookArrived("C# in Depth");
        catalog.RemoveObserver(user1);
        catalog.NewBookArrived("ASP.NET Core Microservices");

        Console.ReadLine();
    }
}