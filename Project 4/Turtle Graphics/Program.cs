using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle_Graphics
{
    class Program
    {
        enum CommandList {PenUp = 1, PenDown = 2, TurnRight = 3, TurnLeft = 4, MoveForward = 5, Print = 6, End = 9};

        static void Main(string[] args)
        {
            //int[,] floor = new int[20, 20];
            int[,] floor = new int[20, 20]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };
            
            int[,] program = new int[2, 1];
            int userNumber;
            int realNumber;
            Console.WriteLine("Welcome to the Turtle Graphics Program");
            Console.WriteLine("Keep in mind your commands.  If you forget, type 'commands' to see them again.");

            ViewCommands();

            TakeInput();

            void ViewCommands()
            {
                Console.WriteLine("1\tPen up");
                Console.WriteLine("2\tPen down");
                Console.WriteLine("3\tTurn right");
                Console.WriteLine("4\tTurn left");
                Console.WriteLine("5,#\tMove forward # spaces");
                Console.WriteLine("6\tPrint the 20 x 20 array");
                Console.WriteLine("9\tEnd of data");
                Console.WriteLine("");
                Console.WriteLine("Please enter a command.");

                TakeInput();
            }

            void TakeInput()
            {
                string userCommand = Console.ReadLine();

                if (userCommand == "commands")
                {
                    ViewCommands();
                }

                else if (userCommand != "commands")
                {
                    try
                    {
                        userNumber = Convert.ToInt32(userCommand);
                        if (userNumber != 1 && userNumber != 2 && userNumber != 3 && userNumber != 4 &&
                            userNumber != 5 && userNumber != 6 && userNumber != 9)
                        {
                            Console.WriteLine("Please enter a valid command number.");
                            ViewCommands();
                        }
                        else
                        {
                            realNumber = userNumber;
                            BeginDrawing();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input.");
                        ViewCommands();
                    }
                }
            }

            void BeginDrawing()
            {
                switch (realNumber)
                {
                    case 1:
                        Console.WriteLine("Command 1 has been entered.");
                        PenUp();
                        break;
                    case 2:
                        Console.WriteLine("Command 2 has been entered.");
                        PenDown();
                        break;
                    case 3:
                        Console.WriteLine("Command 3 has been entered.");
                        TurnRight();
                        break;
                    case 4:
                        Console.WriteLine("Command 4 has been entered.");
                        TurnLeft();
                        break;
                    case 5:
                        Console.WriteLine("Command 5 has been entered.");
                        Console.WriteLine("Please enter the distance to travel.");
                        MoveForward();
                        break;
                    case 6:
                        Console.WriteLine("Command 6 has been entered.");
                        PrintData();
                        break;
                    case 9:
                        Console.WriteLine("Command 9 has been entered.");
                        ExitApp();
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }

            void PenUp()
            {
                TakeInput();
            }

            void PenDown()
            {
                TakeInput();
            }

            void TurnRight()
            {
                TakeInput();
            }

            void TurnLeft()
            {
                TakeInput();
            }

            void MoveForward()
            {
                string userInput = Console.ReadLine();

                try
                {
                    int userDistance = Convert.ToInt32(userInput);

                    if (userDistance >= 0 && userDistance <= 20)
                    {
                        Console.WriteLine("Turtle has moved {0} spaces.", userDistance);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number 0 - 20.");
                        MoveForward();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input.\nReturning to commands.");
                    ViewCommands();
                }

                TakeInput();
            }

            void PrintData()
            {
                int rowLength = floor.GetLength(0);
                int colLength = floor.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write(string.Format("{0} ", floor[i, j]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
                TakeInput();
            }

            void ExitApp()
            {
                TakeInput();
            }
        }
    }
}