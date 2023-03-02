namespace Part_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection;
            bool done, done1;
            done = false;
            done1 = false;
            double price;
            int age;
            /*
            do
            {
                Console.WriteLine("Who has a better captain? ");
                Console.WriteLine("a - Captain Kirk");
                Console.WriteLine("b - Captain Pircard");
                selection = Console.ReadLine();
            } while (selection != "a");


            do
            {
                Console.WriteLine("Hello");
                Console.WriteLine("How much money do you have?");
                if (Double.TryParse(Console.ReadLine(), out price))
                {
                    done = true;
                }

            }while (done != true);

            Console.WriteLine(price);
            */

            while (done1 != true)
            {
                Console.Write("How old are you? ");
                if (Int32.TryParse(Console.ReadLine(), out age))
                {
                    if (age <= 0)
                    {
                    }
                    else
                    {
                        done1 = true;
                    }
                }
            }
        }   
    }
}