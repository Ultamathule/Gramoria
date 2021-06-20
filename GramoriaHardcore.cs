using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Menus
    {

       public int menuNumber = 1;
       public int menuOptionNum = 1;

        
       
        

        public void showMenu()
        {
            switch (menuNumber) // which menu is it?
            {

                case 1: // Title Menu
                    { // Draw Title Screen
                                {
                                    Console.SetCursorPosition(0, 5); // Game Name
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("______________________________________________________--Gramoria--______________________________________________________");

                                    Console.SetCursorPosition(55, 20);
                                    Console.Write("Press Enter");
                                }
                                break;
                        
                    }

                  
                case 2: // Main Menu?? save, load, char select?? 
                    {
                        switch (menuOptionNum)
                        {
                            case 1:
                                Console.Clear();
                                
                                Console.SetCursorPosition(55, 6);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Main Menue");

                                Console.SetCursorPosition(55, 8);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Continue"); 
                                Console.SetCursorPosition(55, 9);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Load");                                                   
                                Console.SetCursorPosition(55, 10);
                                Console.Write("Start New Game"); 
                                Console.SetCursorPosition(55, 11);
                                Console.Write("Generate World"); 
                                Console.SetCursorPosition(55, 12);
                                Console.Write("Options"); 
                                Console.SetCursorPosition(55, 13);
                                Console.Write("High Score");
                                Console.SetCursorPosition(55, 14);
                                Console.Write("Quit");
                                     break;
                            case 2:
                                Console.Clear();
                                Console.SetCursorPosition(55, 6);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Main Menue");

                                Console.SetCursorPosition(55, 8);
                                Console.Write("Continue");
                                Console.SetCursorPosition(55, 9);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Load");                                                     
                                Console.SetCursorPosition(55, 10);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Start New Game"); 
                                Console.SetCursorPosition(55, 11);
                                Console.Write("Generate World"); 
                                Console.SetCursorPosition(55, 12);
                                Console.Write("Options"); 
                                Console.SetCursorPosition(55, 13);
                                Console.Write("High Score");
                                Console.SetCursorPosition(55, 14);
                                Console.Write("Quit");

                                     break;
                           case 3:
                                Console.Clear();
                                Console.SetCursorPosition(55, 6);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Main Menue");


                                Console.SetCursorPosition(55, 8);
                                Console.Write("Continue");
                                Console.SetCursorPosition(55, 9);
                                Console.Write("Load");
                                Console.SetCursorPosition(55, 10);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Start New Game");
                                Console.SetCursorPosition(55, 11);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Generate World");
                                Console.SetCursorPosition(55, 12);
                                Console.Write("Options");
                                Console.SetCursorPosition(55, 13);
                                Console.Write("High Score");
                                Console.SetCursorPosition(55, 14);
                                Console.Write("Quit");
                                     break;
                           case 4:
                                Console.Clear();
                                Console.SetCursorPosition(55, 6);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Main Menue");


                                Console.SetCursorPosition(55, 8);
                                Console.Write("Continue");
                                Console.SetCursorPosition(55, 9);
                                Console.Write("Load");
                                Console.SetCursorPosition(55, 10);
                                Console.Write("Start New Game");
                                Console.SetCursorPosition(55, 11);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Generate World");
                                Console.SetCursorPosition(55, 12);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Options");
                                Console.SetCursorPosition(55, 13);
                                Console.Write("High Score");
                                Console.SetCursorPosition(55, 14);
                                Console.Write("Quit");
                                     break;                                                                                          
                           case 5:
                                Console.Clear();
                                Console.SetCursorPosition(55, 6);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Main Menue");


                                Console.SetCursorPosition(55, 8);
                                Console.Write("Continue");
                                Console.SetCursorPosition(55, 9);
                                Console.Write("Load");
                                Console.SetCursorPosition(55, 10);
                                Console.Write("Start New Game");
                                Console.SetCursorPosition(55, 11);
                                Console.Write("Generate World");
                                Console.SetCursorPosition(55, 12);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Options");
                                Console.SetCursorPosition(55, 13);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("High Score");
                                Console.SetCursorPosition(55, 14);
                                Console.Write("Quit");
                                     break;
                           case 6:
                                Console.Clear();
                                Console.SetCursorPosition(55, 6);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Main Menue");


                                Console.SetCursorPosition(55, 8);
                                Console.Write("Continue");
                                Console.SetCursorPosition(55, 9);
                                Console.Write("Load");
                                Console.SetCursorPosition(55, 10);
                                Console.Write("Start New Game");
                                Console.SetCursorPosition(55, 11);
                                Console.Write("Generate World");
                                Console.SetCursorPosition(55, 12);
                                Console.Write("Options");
                                Console.SetCursorPosition(55, 13);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("High Score");
                                Console.SetCursorPosition(55, 14);
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.Write("Quit");
                                     break;
                           case 7:
                                Console.Clear();
                                Console.SetCursorPosition(55, 6);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Main Menue");


                                Console.SetCursorPosition(55, 8);
                                Console.Write("Continue");
                                Console.SetCursorPosition(55, 9);
                                Console.Write("Load");
                                Console.SetCursorPosition(55, 10);
                                Console.Write("Start New Game");
                                Console.SetCursorPosition(55, 11);
                                Console.Write("Generate World");
                                Console.SetCursorPosition(55, 12);
                                Console.Write("Options");
                                Console.SetCursorPosition(55, 13);
                                Console.Write("High Score");
                                Console.SetCursorPosition(55, 14);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Quit");
                                     break;
                                
                        }

                    }
                    break;
                case 3: // New world Parameters
                    {
                        switch (menuOptionNum)
                        {
                            case 1: // world size or dificulty
                                break;
                            case 2:
                                break;
                        }

                    }
                    break;
                case 4: // option menue....here when we need it, otherwise has no failure on the game!!
                    {
                        switch (menuOptionNum)
                        {
                            case 1: // return
                                Console.Clear();
                                Console.SetCursorPosition(55, 5);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("Options");
                                break;
                            case 2: // idk maybe volume if i even want sound??
                                break;
                        }
                    }
                    break;
                case 5: // quit, double check
                    {
                        switch (menuOptionNum)
                        {
                            case 1: // quit
                                Console.Clear();
                                Console.SetCursorPosition(46, 5);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Are you sure, Quit?");
                                Console.SetCursorPosition(55, 7);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Yes");
                                Console.SetCursorPosition(55, 8);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("No");
                                return;
                            case 2: // Return
                                Console.Clear();
                                Console.SetCursorPosition(46, 5);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Are you sure, Quit?");
                                Console.SetCursorPosition(55, 7);
                                Console.Write("Yes");
                                Console.SetCursorPosition(55, 8);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("No");
                                return;
                        }
                    }
                    break;
                case 6: // new game pre-game options
                    {
                        switch (menuOptionNum)
                        {
                            case 1: // set name
                                Console.Clear();
                                //Console.SetCursorPosition(0, 5);

                                break;
                            case 2: // dificulty
                                break;
                            case 3: // pick race
                                break;
                            case 4: // pick class
                                break;
                        }
                    }
                    break;
                case 7: // in game menues like invintory and such, quit screen etc...
                    break;
               // case 8: -----if i want to add another menue oprion???
                //    break;
             
                }
            }
        
    }
}
