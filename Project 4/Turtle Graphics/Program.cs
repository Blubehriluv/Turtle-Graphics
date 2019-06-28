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
            int[,] floor = new int[20, 20];
            int[,] program = new int[2, 1];
            int userNumber;
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
                if (userNumber == 1)
                {
                    Console.WriteLine("Command 1 has been entered.");
                }

                if (userNumber == 2)
                {
                    Console.WriteLine("Command 2 has been entered.");
                }

                if (userNumber == 3)
                {
                    Console.WriteLine("Command 3 has been entered.");
                }

                if (userNumber == 4)
                {
                    Console.WriteLine("Command 4 has been entered.");
                }

                if (userNumber == 5)
                {
                    Console.WriteLine("Command 5 has been entered.");
                }

                if (userNumber == 6)
                {
                    Console.WriteLine("Command 6 has been entered.");
                }

                if (userNumber == 9)
                {
                    Console.WriteLine("Command 9 has been entered.");
                }

                Console.WriteLine("The user is now drawing.");
                Console.WriteLine("");
                TakeInput();
            }
        }
    }
}