using System;

namespace cSharpMethodOverloading
{
    class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // this.X = newLocation.X;
            // this.Y = newLocation.Y;  
            if ( newLocation == null)                           //DEFENCIVE programming
                throw new ArgumentNullException("newLocation"); // A way to throw errors, the argument is the name of the parameter
            Move(newLocation.X, newLocation.Y);
        }
    }
}
