using DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        //Singleton Pattern
        //LibraryCatalog catalog1 = LibraryCatalog.Instance;
        //LibraryCatalog catalog2 = LibraryCatalog.Instance;
        //catalog1.ShowMessage();
        //Console.WriteLine(catalog1 == catalog2);


        //FactoryMethod Pattern
        //ReportCreator creator;
        //creator = new PDFReportCreator();
        //creator.GenerateReport();
        //creator = new ExcelReportCreator();
        //creator.GenerateReport();
        //creator = new WordReportCreator();
        //creator.GenerateReport();


        //AbstractFactory Pattern
        IVehicleFactory factory;
        factory = new RegularVehicleFactory();
        IBike bike = factory.CreateBike();
        ICar car = factory.CreateCar();
        bike.GetDetails();
        car.GetDetails();
        factory = new SportsVehicleFactory();
        bike = factory.CreateBike();
        car = factory.CreateCar();
        bike.GetDetails();
        car.GetDetails();
    }
}