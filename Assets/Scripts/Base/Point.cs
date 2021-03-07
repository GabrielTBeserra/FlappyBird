namespace Base
{
    public class Point
    {
        public int Points { get; set; }

        public Point(int p)
        {
            Points = p;
        }

        public void AddPoint(int points)
        {
            Points += points;
        }
        
        public void SetPoints(int points)
        {
            Points = points;
        }
    }
}