namespace GPS
{
    internal struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override int GetHashCode()
        {
            return X + Y;
        }

        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                var p = (Point) obj;
                {
                    return p.X == X && p.Y == Y;
                }
            }
            return false;
        }
    }
}