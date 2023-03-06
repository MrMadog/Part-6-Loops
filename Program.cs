using System.Net.Security;

namespace Part_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

// PROGRAM ONE --------------------------------------------------------------------------------------------------------------------------------------

            static void Program1()
            {
                int minNum, maxNum, userAnswer;
                bool done, done1, done2;
                done = false;
                done1 = false;
                done2 = false;

                Console.WriteLine();
                Console.WriteLine("Running Prompter... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();

                do
                {
                    Console.Write("Enter a minimum value:  ");
                    if (Int32.TryParse(Console.ReadLine(), out minNum))
                    {
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                    }
                } while(!done);

                do
                {
                    Console.Write("Enter a maximum value:  ");
                    if (Int32.TryParse(Console.ReadLine(), out maxNum))
                    {
                        if (maxNum <= minNum)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Maximum value can not be less than minimum value.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            done1 = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                    }
                } while(!done1);

                do
                {
                    Console.Write($"Enter a number between {minNum} and {maxNum}:  ");
                    if (Int32.TryParse(Console.ReadLine(), out userAnswer))
                    {
                        if (userAnswer <= maxNum && userAnswer >= minNum)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Well Done!");
                            Thread.Sleep(1000);
                            done2 = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid Input");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                    }
                } while(!done2);

                Console.WriteLine();
                Console.WriteLine("Program finished, press ENTER to continue to menu");
                Console.ReadLine();
            }

// PROGRAM TWO --------------------------------------------------------------------------------------------------------------------------------------

            static void Program2()
            {
                bool done = false;
                int number;

                Console.WriteLine();
                Console.WriteLine("Running Percent Passer... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("Enter 'Q' to when you are finished printing scores.");
                do
                {
                    Console.Write("Enter a score (0 - 100):  ");
                    while (Int32.TryParse(Console.ReadLine(), out number))
                    {
                        if (number > 100)
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        Console.WriteLine(number);
                    }
                    done = true;
                } while(!done);
                
                Console.WriteLine(number);
            }

// PROGRAM THREE ------------------------------------------------------------------------------------------------------------------------------------

            static void Program3()
            {
                int number, oddSum;
                oddSum = 0;

                Console.WriteLine();
                Console.WriteLine("Running Odd Sum... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < number + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        
                    }
                    else
                    {
                        oddSum += i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"You entered; {number}, and the odd sum is; {oddSum}. ");

                Console.WriteLine();
                Console.WriteLine("Program finished, press ENTER to continue to menu");
                Console.ReadLine();

            }

// PROGRAM FOUR -------------------------------------------------------------------------------------------------------------------------------------


            static void Program4()
            {

                Console.WriteLine();
                Console.WriteLine("Running Random Numbers... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();


            }

// PROGRAM FIVE -------------------------------------------------------------------------------------------------------------------------------------

            static void Program5()
            {

                Console.WriteLine();
                Console.WriteLine("Running Dice Game... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();


            }


        }   
    }
}