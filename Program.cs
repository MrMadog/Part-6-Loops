namespace Part_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection;
            do
            {
                Console.WriteLine("Who is the better captain?");
                Console.WriteLine("a - Captain Picard");
                Console.WriteLine("b - Captain Kirk");
                selection = Console.ReadLine();
            } while (selection != "a");
            Console.WriteLine("Correct");
        }
    }
}