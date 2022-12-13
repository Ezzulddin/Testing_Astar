namespace Testing_Astar
{
    public struct Location
    {
        public readonly int X;

        public readonly int Y;

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public static bool operator ==(Location locationA, Location locationB) => locationA.Equals(locationB);

        public static bool operator !=(Location locationA, Location locationB) => !locationA.Equals(locationB);

        public override int GetHashCode() => base.GetHashCode();

        public override bool Equals(object obj) => base.Equals(obj);

    }
}
