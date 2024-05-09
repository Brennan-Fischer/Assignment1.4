namespace Assignment1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            if (point1.x == point2.x)
            {
                Console.WriteLine("Point1 is on the same x axis as point2");
            }
            else
            {
                Console.WriteLine("Point not on same x axis");
            }
        }

        
    }

    public struct Point
    {
        public double x;
        public double y;
    }

}
