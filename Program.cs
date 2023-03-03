namespace Part_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            
            string selection;
            bool done, done1;
            done = false;
            done1 = false;
            double price;
            int age;
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
*/

            string program;
            bool done = false;

            while (done != true)
            {
                Console.WriteLine();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Percent Passing");
                Console.WriteLine("3 - Odd Sum");
                Console.WriteLine("4 - Random Numbers");
                Console.WriteLine("5 - Dice Game");
                Console.WriteLine("q - Quit");
                Console.Write("Choice:  ");

                program = Console.ReadLine().ToUpper();

                if (program == "1")
                {
                    Program1();
                }
                else if (program == "2")
                {
                    Program2();
                }
                else if (program == "3")
                {
                    Program3();
                }
                else if (program == "4")
                {
                    Program4();
                }
                else if (program == "5")
                {
                    Program5();
                }
                else if (program == "Q" || program == "QUIT")
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine();
                }
            }

            static void Program1()
            {
                Console.WriteLine("Running Program 1... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
            }

            static void Program2()
            {
                Console.WriteLine("Running Program 2... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
            }

            static void Program3()
            {
                Console.WriteLine("Running Program 3... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
            }

            static void Program4()
            {
                Console.WriteLine("Running Program 4... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
            }

            static void Program5()
            {
                Console.WriteLine("Running Program 5... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
            }


        }   
    }
}