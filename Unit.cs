using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   /* public class Unit
    {

        //this is also a constructor i think??
        public Unit(int x, int y, string unitGraphic)
        {
            this.UnitGraphic = unitGraphic;
            this.X = x;
            this.Y = y;
            this.UnitGraphic = unitGraphic;
        }

        public int X  // The way the rest of the program actually interacts with X

        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0 || value >= Console.WindowWidth)
                {
                    throw new Exception("Invalid X coordinate passed.");
                }
                Undraw();   // We are moving, so undraw!
                _x = value;


            }

        }
        private int _x; // Where the value of x is actually stored


        public int Y

        {
            get
            {
                return _y;
            }
            set
            {
                if (value < 0 || value >= Console.WindowHeight)
                {
                    throw new Exception("Invalid Y coordinate passed.");
                }
                Undraw();   // We are moving, so undraw!
                _y = value;
            }
        }

        private int _y; //Where the value of y is actually stored {

        public string UnitGraphic { get; set; }


        virtual public void Update(int deltTimeMS)
        {

            // this is an instance method that gets run every
            // Frame, where the unit should resolve any gamy
            // things that are going on.
            // The idea is that all Units Update themselves,
            // then all units will be drawn.

            // Since this update runs for both enemys AND Players,
            // it will need to be OVERRIDEN by the child classes.
            // IF I COMMENT THIS OUT IT WILL RUN??(THE EXCEPTION)

        }

        // This draws the unit on the screen.
        virtual public void Draw()
        {
            // This is an instance method, so if we refer
            // to fields like x and y, we will be using
            // the values that belong to this instance,
            // and this instance ONLY.
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.UnitGraphic);

        }
        public void Undraw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(' ');
        }

        public bool IsCollidingWith(Unit other)
        {
            // "this" is the current Unit
            // "other" is the other Unit

            if (this.X == other.X && this.Y == other.Y)
            {
                // We are in the same square, so we are colliding.
                return true;
            }

            return false;
        }

    }*/
}
