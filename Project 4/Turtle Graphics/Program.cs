using System;

namespace Turtle_Graphics
{
    class Program
    {
        //enum CommandList {PenUp = 1, PenDown = 2, TurnRight = 3, TurnLeft = 4, MoveForward = 5, Print = 6, End = 9};

        static void Main(string[] args)
        {
            //Public variables to be used throughout the program
            int rowNum = 0;
            int colNum = 0;
            int realNumber;
            int userDistance;
            int penActive = 0;
            bool isDrawing = false;
            bool goUp = false;
            bool goDown = false;
            bool goLeft = false;
            bool goRight = true;

            //Floor array containing the canvas
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
            
            //Unused array for the program
            int[,] program = new int[2, 1];
            
            //Program introduction
            Console.WriteLine("Welcome to the Turtle Graphics Program");
            Console.WriteLine("Keep in mind your commands.  If you forget, type 'commands' to see them again.");

            ViewCommands();

            TakeInput();

            //Prints the commands for the user
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

            //This receives the user's input for the next command to be entered
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
                        int userNumber = Convert.ToInt32(userCommand);
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

            //Once the user enters a command, the program directs to the proper method
            void BeginDrawing()
            {
                switch (realNumber)
                {
                    case 1:
                        Console.WriteLine("Command 1: Pen Up executed.");
                        PenUp();
                        break;
                    case 2:
                        Console.WriteLine("Command 2: Pen Down executed.");
                        PenDown();
                        break;
                    case 3:
                        Console.WriteLine("Command 3: Turn Right executed.");
                        TurnRight();
                        break;
                    case 4:
                        Console.WriteLine("Command 4: Turn Left executed.");
                        TurnLeft();
                        break;
                    case 5:
                        Console.WriteLine("Command 5: Move forward executed.");
                        Console.WriteLine("Please enter the distance to travel.");
                        MoveForward();
                        break;
                    case 6:
                        Console.WriteLine("Command 6: Print Canvas executed.");
                        PrintData();
                        break;
                    case 9:
                        Console.WriteLine("Command 9: End Program executed.");
                        ExitApp();
                        break;
                }
            }

            //Command 1 executes the pen up command to let the user lift the pen
            void PenUp()
            {
                if (isDrawing)
                {
                    isDrawing = false;
                    penActive = 0;
                    Console.WriteLine("Turtle break time...");
                    TakeInput();
                }
                else
                {
                    Console.WriteLine("The pen is already up!");
                    TakeInput();
                }
                
            }

            //Command 2 executes the pen down command to let the user place it down
            void PenDown()
            {
                if (isDrawing == false)
                {
                    isDrawing = true;
                    penActive = 1;
                    Console.WriteLine("Ready to draw!");
                    TakeInput();
                }
                else
                {
                    Console.WriteLine("You are already drawing!");
                    TakeInput();
                }
                
            }

            //Command 3 executes to let the turtle turn right
            void TurnRight()
            {
                if (goDown)
                {
                    goLeft = true;
                    goDown = false;
                }

                if (goUp)
                {
                    goRight = true;
                    goUp = false;
                }

                if (goLeft)
                {
                    goUp = true;
                    goLeft = false;
                }

                if (goRight)
                {
                    goDown = true;
                    goRight = false;
                }
                TakeInput();
            }

            //Command 4 executes to let the turtle turn left
            void TurnLeft()
            {
                
                if (goDown)
                {
                    goRight = true;
                    goDown = false;
                }

                if (goUp)
                {
                    goLeft = true;
                    goUp = false;
                }

                if (goLeft)
                {
                    goDown = true;
                    goLeft = false;
                }

                if (goRight)
                {
                    goLeft = true;
                    goRight = false;
                }
                TakeInput();
            }

            //Command 5 executes to let the turtle move forward however many spaces the user enters
            void MoveForward()
            {
                string userInput = Console.ReadLine();

                try
                {
                    //This attempts to convert the userInput to int.
                    userDistance = Convert.ToInt32(userInput);

                    //Checks that the user is painting within the bounds of the program
                    if (userDistance >= 0 && userDistance <= 20)
                    {
                        Console.WriteLine("Turtle has moved {0} spaces.", userDistance);
                        TurtleMoving();
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

            //Checks for the direction that the turtle is facing and moves them in that direction while changing the tiles.
            void TurtleMoving()
            {
                //If the turtle is facing downward
                if (goDown)
                {
                    //The loop keeps moving the turtle forward until the given distance is zero
                    while (userDistance > 0)
                    {
                        //penActive draws or doesn't draw on the floor while moving the turtle.
                        floor.SetValue(penActive, rowNum, colNum);
                        userDistance--;
                        colNum++;
                    }
                    TakeInput();
                }
                //If the turtle is facing up
                if (goUp)
                {
                    //The loop keeps moving the turtle forward until the given distance is zero
                    while (userDistance > 0)
                    {
                        //penActive draws or doesn't draw on the floor while moving the turtle.
                        floor.SetValue(penActive, rowNum, colNum);
                        userDistance--;
                        colNum--;
                    }
                    TakeInput();
                }
                //If the turtle is facing the left
                if (goLeft)
                {
                    //The loop keeps moving the turtle forward until the given distance is zero
                    while (userDistance > 0)
                    {
                        //penActive draws or doesn't draw on the floor while moving the turtle.
                        floor.SetValue(penActive, rowNum, colNum);
                        userDistance--;
                        rowNum--;
                    }
                    TakeInput();
                }
                //If the turtle is facing the right
                if (goRight)
                {
                    //The loop keeps moving the turtle forward until the given distance is zero
                    while (userDistance > 0)
                    {
                        //penActive draws or doesn't draw on the floor while moving the turtle.
                        floor.SetValue(penActive, rowNum, colNum);
                        userDistance--;
                        rowNum++;
                    }
                    TakeInput();
                }
            }

            //This prints the canvas for the user to see, with the updated drawing
            void PrintData()
            {
                int rowLength = floor.GetLength(0);
                int colLength = floor.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (floor[i, j] == 0)
                        {
                            Console.Write("O ");
                        }

                        if (floor[i, j] == 1)
                        {
                            Console.Write("X ");
                        }
                        //Console.Write("{0} ", floor[i, j]);
                    }
                    Console.Write(Environment.NewLine);
                }
                TakeInput();
            }

            void ExitApp()
            {
                Console.WriteLine("Thank you for using the Turtle Graphics program!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
        }
    }
}