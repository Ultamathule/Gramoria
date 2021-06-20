using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program1
    {
        static void Main(string[] args)
        {

            Console.SetCursorPosition(0, 5); // Game Name
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("______________________________________________________--Gramoria--______________________________________________________");
            // Define the window...
            Console.SetWindowSize(90, 40);
            Console.SetBufferSize(120, 60);
            Console.SetWindowSize(120, 60); // Your window may never be larger than your buffer..
           
            //Cursor Troubles
            Console.CursorVisible = false;


            // Declarations (Class Structs and Objects)
            // Instantations (Instances of classes, structs and Objects)
            Menus MenuManager = new Menus();
           

            // Must have a loop
            bool gamerunning = true; // just to keep this loop running
            while (gamerunning == true) // when it is false, the window will close
            {  //show the menus
                Console.Clear();
                MenuManager.showMenu(); // draw the active menu

                // get input
                ConsoleKeyInfo MenuIn = Console.ReadKey(true);

                
                // send output
                switch (MenuIn.Key)
                {
                    case ConsoleKey.Escape: // the kill key
                        {
                            gamerunning = false;
                        }
                        break;
                    case ConsoleKey.Enter:
                        {
                            switch(MenuManager.menuNumber)
                            {
                                case 1: // ECT...
                                    switch (MenuManager.menuOptionNum)
                                    {
                                        case 1:

                                            MenuManager.menuNumber = 2; 
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch(MenuManager.menuOptionNum)
                                    {
                                        case 1: // Continue Game
                                            break;
                                        case 2: // Load a spacific game
                                            break;
                                        case 3: // new game
                                            break;
                                        case 4: //Generate new world
                                            break;
                                        case 5: //options menu
                                            MenuManager.menuNumber = 4;
                                          
                                            MenuManager.menuOptionNum = 1;
                                            break;
                                        case 6: // ???
                                            break;
                                        case 7: // quit
                                            MenuManager.menuNumber = 5;
                                            MenuManager.menuOptionNum = 1;
                                            break;
                                      

                                    }
                                    break;
                                case 3:// generate world
                                    break;
                                case 4: // options
                                    MenuManager.menuNumber = 2;
                                    break;
                                case 5: // quit menu
                                    switch  (MenuManager.menuOptionNum)
                                    {
                                        case 1: // go back to main menu or not
                                            gamerunning = false;
                                            break;
                                        case 2:// ask if there sure they want to quit??
                                           
                                            MenuManager.menuNumber = 2;
                                            MenuManager.menuOptionNum = 1;
                                            break;
                                    }
                                    break;
                                case 6: // pick race
                                    break;
                                case 7: // in game menu
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.W: //Menu UP
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.NumPad8:
                        {
                            switch (MenuManager.menuNumber)
                            {
                                case 1: //Title Menu
                                    { MenuManager.menuNumber = 2; }

                                    break; // Next Menu

                                case 2: //Main Menu
                                    {
                                        if (MenuManager.menuOptionNum > 1)

                                        { MenuManager.menuOptionNum = MenuManager.menuOptionNum - 1; }

                                        // Down is up

                                        else
                                        { MenuManager.menuOptionNum = 7; }

                                        break;
                                    }
                                case 5: // quit menu
                                    {
                                        if (MenuManager.menuOptionNum == 1)
                                        { MenuManager.menuOptionNum = 2; }
                                        else
                                        { MenuManager.menuOptionNum = 1; }
                                    }

                                    break;
                            }

                        }
                        break;
                    case ConsoleKey.S: // Menu DOWN
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.NumPad2:
                        {
                            switch (MenuManager.menuNumber)
                            {
                                case 1: // Title Menu
                                    {
                                        MenuManager.menuNumber = 2; // lazy
                                                                    // and it does the same thing??
                                    }
                                    break;

                                case 2:
                                    { // Main menu
                                        if (MenuManager.menuOptionNum < 7) // watch for (8) here????????
                                        { MenuManager.menuOptionNum = MenuManager.menuOptionNum + 1; }
                                        else
                                        { MenuManager.menuOptionNum = 1; }
                                        }
                                         break;
                                case 5:
                                    {
                                        if (MenuManager.menuOptionNum == 1)
                                        { MenuManager.menuOptionNum = 2; }
                                        else
                                        { MenuManager.menuOptionNum = 1; }
                                    }
                                    break;
                                    }
                                    break;
                           
                }

                }
                 
            }

        }


    }
    
    }
    



