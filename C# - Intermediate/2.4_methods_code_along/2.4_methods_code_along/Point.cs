namespace _2._4_methods_code_along
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public void Move(int x, int y) // to change point's location
        {
            this.X = x;
            this.Y = y; 
        }
        
        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new System.ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }
}
