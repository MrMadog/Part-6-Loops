using Part_5._5___More_Classes;
using System.Net.Security;

namespace Part_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string program;
            bool done = false;

            while (!done)
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
                int score, i;
                double percent, valid;
                i = 0;
                valid = 0;

                Console.WriteLine();
                Console.WriteLine("Running Percent Passer... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("You are going to be entering test scores (0 - 100). ");
                Thread.Sleep(1000);
                Console.WriteLine();

                Console.WriteLine("Enter a negative number if you would like to quit. ");
                Thread.Sleep(1500);
                Console.WriteLine();

                do
                {
                    Console.Write("Enter a score:  ");

                    while (!Int32.TryParse(Console.ReadLine(), out score))
                    {
                        Console.WriteLine("Invalid Input. ");
                        Console.WriteLine();
                        Console.Write("Enter a score:  ");
                    }


                    if (score < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Quitting... ");
                        Thread.Sleep(1000);
                        done = true;
                    }

                    if (score >= 0 && score <= 100)
                    {
                        i += 1;


                        if (score >= 70 && score <= 100)
                        {
                            valid += 1;
                        }
                    }
                    else if (score > 100)
                    {
                        Console.WriteLine("Invalid Input. ");
                        Console.WriteLine();
                    }

                    percent = valid / i;

                    if (percent >= 1)
                    {
                        percent = 1;
                    }
                    else if (percent <= 0)
                    {
                        percent = 0;
                    }

                    percent = percent * 100;
                    percent = Math.Round(percent, 2);

                } while (!done);

                if (i >= 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{percent}% of your given scores were above a 70%! ");
                }

                Console.WriteLine();
                Console.WriteLine("Program finished, press ENTER to continue to menu");
                Console.ReadLine();
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
                Random generator = new Random();

                int minNum, maxNum, randNum, num;
                bool done;
                done = false;
                num = 1;

                Console.WriteLine();
                Console.WriteLine("Running Random Numbers... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();

                do
                {
                    Console.Write("Enter a MINIMUM value:  ");
                    if (!Int32.TryParse(Console.ReadLine(), out minNum))
                    {
                        Console.WriteLine("Invalid Input. ");
                    }
                    else
                    {
                        done = true;
                    }

                } while (!done);

                Console.WriteLine();
                Thread.Sleep(500);

                do
                {
                    Console.Write("Enter a MAXIMUM value:  ");
                    if (!Int32.TryParse(Console.ReadLine(), out maxNum))
                    {
                        Console.WriteLine("Invalid Input. ");
                    }
                    else
                    {
                        done = true;
                    }

                } while (!done);

                Console.WriteLine();
                Thread.Sleep(500);

                maxNum += 1;

                for (int i = 1; i < 26; i++)
                {
                    Console.Write($"{num}. ");
                    num += 1;
                    randNum = generator.Next(minNum, maxNum);
                    Console.WriteLine(randNum);
                    Thread.Sleep(101);
                }

                Console.WriteLine();
                Console.WriteLine("Program finished, press ENTER to continue to menu");
                Console.ReadLine();
            }

// PROGRAM FIVE -------------------------------------------------------------------------------------------------------------------------------------

            static void Program5()
            {

                Console.WriteLine();
                Console.WriteLine("Running Dice Game... ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();

                int bet, roll1, roll2, sum;
                double betAmount, accountBalance;
                bool done, done1;
                string answer;
                done = false;
                done1 = false;
                accountBalance = 100.00;

                Die die1 = new Die();

                Console.WriteLine("Dice Game --");
                Console.WriteLine();
                Thread.Sleep(500);
                while (done != true)
                {
                    Console.WriteLine("In this game, you will bet on the outcome of 2 dice being rolled.");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine($"Your account balance is: ${accountBalance}");
                    Console.WriteLine();
                    Thread.Sleep(1000);

                    // BET ----------------------------------------------------------------------------------------------------------------------------------
                    do
                    {
                        Console.WriteLine("Your bet options are: ");
                        Console.WriteLine("1 - Doubles, 2 - not Doubles, 3 - Even Sum, 4 - Odd Sum");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.Write("YOUR BET:  ");
                        if (Int32.TryParse(Console.ReadLine(), out bet))
                        {
                            if ((bet != 1 && bet != 2 && bet != 3 && bet != 4))
                            {
                                Console.WriteLine();
                                Thread.Sleep(500);
                                Console.WriteLine("Invalid Input");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine();
                        }
                    } while (bet != 1 && bet != 2 && bet != 3 && bet != 4);

                    // BET AMOUNT ---------------------------------------------------------------------------------------------------------------------------
                    do
                    {
                        Console.WriteLine();
                        Console.Write("YOUR BET AMOUNT:  $");
                        if (Double.TryParse(Console.ReadLine(), out betAmount))
                        {
                            done1 = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.WriteLine("Invalid Input");
                        }
                    } while (done1 != true);

                    betAmount = Math.Round(betAmount, 2);
                    if (betAmount < 0)
                    {
                        betAmount = 0.00;
                    }
                    else if (betAmount > accountBalance)
                    {
                        betAmount = accountBalance;
                    }

                    // ROLLING ------------------------------------------------------------------------------------------------------------------------------
                    Console.WriteLine();
                    Console.Write("Press ENTER to roll ");
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Rolling...");
                    Thread.Sleep(1500);
                    Console.WriteLine();

                    Console.WriteLine("Die 1: ");
                    die1.RollDie();
                    die1.DrawRoll();
                    roll1 = die1.Roll;
                    Thread.Sleep(1000);

                    Console.WriteLine("Die 2: ");
                    die1.RollDie();
                    die1.DrawRoll();
                    roll2 = die1.Roll;
                    Console.WriteLine();

                    sum = roll1 + roll2;

                    // DOUBLES ------------------------------------------------------------------------------------------------------------------------------
                    if (bet == 1)
                    {
                        Console.WriteLine("Your bet was Doubles: ");

                        if (roll1 == roll2)
                        {
                            Console.WriteLine("YOU WIN!");
                            accountBalance = accountBalance + betAmount * 2;
                            Console.WriteLine($"You bet ${betAmount} on Doubles, and won ${betAmount * 2}.");
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE!");
                            accountBalance = accountBalance - betAmount;
                            Console.WriteLine($"You bet ${betAmount} on Doubles, and lost ${betAmount}.");
                        }
                        Math.Round(accountBalance, 2);
                        Console.WriteLine($"Your account now stands at ${accountBalance}.");
                    }

                    // NOT DOUBLES --------------------------------------------------------------------------------------------------------------------------
                    else if (bet == 2)
                    {
                        Console.WriteLine("Your bet was Not Doubles: ");

                        if (roll1 != roll2)
                        {
                            Console.WriteLine("YOU WIN!");
                            accountBalance = accountBalance + betAmount * 0.5;
                            Console.WriteLine($"You bet ${betAmount} on Not Doubles, and won ${betAmount / 2}.");
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE!");
                            accountBalance = accountBalance - betAmount;
                            Console.WriteLine($"You bet ${betAmount} on Not Doubles, and lost ${betAmount}.");
                        }
                        Math.Round(accountBalance, 2);
                        Console.WriteLine($"Your account now stands at ${accountBalance}.");
                    }

                    // EVEN SUM -----------------------------------------------------------------------------------------------------------------------------
                    else if (bet == 3)
                    {
                        Console.WriteLine("Your bet was Even Sum: ");

                        if (sum % 2 == 0)
                        {
                            Console.WriteLine("YOU WIN!");
                            accountBalance = accountBalance + betAmount;
                            Console.WriteLine($"You bet ${betAmount} on Even Sum, and won ${betAmount}.");
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE!");
                            accountBalance = accountBalance - betAmount;
                            Console.WriteLine($"You bet ${betAmount} on Even Sum, and lost ${betAmount}.");
                        }
                        Math.Round(accountBalance, 2);
                        Console.WriteLine($"Your account now stands at ${accountBalance}.");
                    }

                    // ODD SUM ------------------------------------------------------------------------------------------------------------------------------
                    else if (bet == 4)
                    {
                        Console.WriteLine("Your bet was Odd Sum: ");

                        if (sum % 2 == 0)
                        {
                            Console.WriteLine("YOU LOSE!");
                            accountBalance = accountBalance - betAmount;
                            Console.WriteLine($"You bet ${betAmount} on Odd Sum, and lost ${betAmount}.");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!");
                            accountBalance = accountBalance + betAmount;
                            Console.WriteLine($"You bet ${betAmount} on Odd Sum, and won ${betAmount}.");
                        }
                        Math.Round(accountBalance, 2);
                        Console.WriteLine($"Your account now stands at ${accountBalance}.");
                    }


                    // QUIT -------------------------------------------------------------------------------------------------------------------------------------
                    Console.WriteLine();
                    Console.Write("Would you like to quit?(Y/N) ");
                    answer = Console.ReadLine().ToUpper();
                    if (answer == "Y" || answer == "YES")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Game Over.");
                        Thread.Sleep(1000);
                        done = true;
                    }
                    else if (answer == "N" && accountBalance < 0 || answer == "NO" && accountBalance < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Insufficient funds");
                        Thread.Sleep(1000);
                        Console.WriteLine("Game Over.");
                        Thread.Sleep(1000);
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Okay, lets continue...");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Program finished, press ENTER to continue to menu");
                Console.ReadLine();
            }
        }   
    }
}