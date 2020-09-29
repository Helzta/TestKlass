using System;

namespace TestKlass
{
    class Program
    {
        static int plusDays = 0;
        //static bool isSwitch = false;
        static void printHubMenu()
        {
            bool isValid = false;
            while(!isValid)
            {
                Console.Clear();
                DateTime dt = new DateTime(2020, 12, 1);
                DateTime dt1 = dt.AddDays(plusDays);
                Console.WriteLine(dt1.ToString("D"));
                Console.WriteLine("\n1. Simulate            2. News\n" +
                                    "3. Team                4. Transfer\n");
                Console.WriteLine("Select the alternative by writing the associated number.");
                Console.Write("User input: ");

                switch(Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        plusDays++;
                        isValid = true;

                        break;
                    
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Yeah this will have to wait, they only 14-18");

                        break;
                    
                    case "3":
                        //bool isNotValid = true;
                        Console.Clear();
                        Console.WriteLine("\n(OP) player 1                  (MB) player 2                 (OH) player 3             (SUB) player 8\n" +
                                            "(OH) player 4                  (Li) player 5                 (Se) player 6             (SUB) player 9\n" +
                                            "                               (MB) player 7                                           (SUB) player 10\n" +
                                            "                                                                                       (SUB) player 11\n" +
                                            "                                                                                       (SUB) player 12\n");
                        Console.WriteLine("Do you want to switch players? [Y / N] : ");
                        switch(Console.ReadLine().ToLower())
                        {
                            case "y":
                                //isNotValid = false;
                                //isSwitch = true;
                                //isValid = true;
                                
                                break;

                            case "n":
                                //isNotValid = false;

                                break;

                            default:
                                Console.WriteLine("You what...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }

                        break;

                        case "4":
                            Console.WriteLine("What?");
                            Console.ReadLine();

                            break;

                }
            }
        }
        static void Main(string[] args)
        {
            bool gameOn = true;

            while(gameOn)
            {
                printHubMenu();
            }
        }
    }
}
