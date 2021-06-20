using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
  /*  public class TheGame
    {
        // This is our constructor -- it gets run automatically
        // when a new INSTANCE of Game is created.
        public TheGame()
        {
            // Instantiate a Unit that will represent
            //the player
            playerUnit = new PlayerUnit(10, 17, "@");

            //now instantiate the enemy
            //enemyUnit = new EnemyUnit(Console.WindowWidth -1 , 17, "X");

            // Instantiate the ARRAY that will hold our enemies
           
            //Right now, our enemyUnits array is instantiated, but each
            // slot is empty.

            Random = new Random();
            Score = 0;

           
            stopwatch = new Stopwatch();
        }

        public static Random Random; // because its "static" its no longer an instance
                                     // but belongs to the game calss as a whole.

        public static int Score;

        private Stopwatch stopwatch;

        private Unit playerUnit;
        //private Unit enemyUnit;

       

        public void Run()
        {
            // We are happy to run at any frame rate whatsoever,
            // however -- do we need to know how much time each 
            // frame is taking.

            stopwatch.Start();
            long timeAtPreviousFrame = stopwatch.ElapsedMilliseconds;

            //1000 / desiredFPS;

            while (true)
            {
                // The time since the last frame
                int deltaTimeMS = (int)(stopwatch.ElapsedMilliseconds - timeAtPreviousFrame);
                timeAtPreviousFrame = stopwatch.ElapsedMilliseconds;

                //Update all of our units
                playerUnit.Update(deltaTimeMS);

                // for each enemy
               
                playerUnit.Draw();

               
                // Draw the score!
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write("SCORE:" + Score.ToString());

                // Let's just do a TINY sleep to avoid running at like.. a billion FPS.
                Thread.Sleep(5);  // This is the best way to delay
                                  // a certain amount of time but 
                                  // i have to enter
                                  // (System.Threading;) at the top!!
            }
        }

      
    }*/
}
