
namespace BirdSanctuary
{
    class Program
    {
        static void Main()
        {
            BirdSanctuary sanctuary = new BirdSanctuary();
            Bird sparrow= new Sparrow(1, "Sparrow", Gender.Female); 
            Bird duck = new Duck(2, "Duck", Gender.Female); 
            Bird penguin = new Penguin(3, "Penguin", Gender.Male);
            Bird penguin1 = new Penguin(3, "Penguin", Gender.Male);

            sanctuary.AddBird(sparrow); 
            sanctuary.AddBird(duck); 
            sanctuary.AddBird(penguin);
            sanctuary.AddBird(penguin1);
            sanctuary.DisplayBirds();

            Console.WriteLine();

            sanctuary.RemoveBird(2, "Shifted to another sanctuary"); 
            sanctuary.RemoveBird(3, "Under treatment");

            Console.WriteLine("After Removing");
            sanctuary.DisplayBirds(); 
            sanctuary.DisplayRemovedBirds();
        }
    }
}