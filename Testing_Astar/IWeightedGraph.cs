using System.Collections.Generic;

namespace Testing_Astar
{
    public interface IWeightedGraph<L>
    {
        double Cost(Location a, Location b);
        IEnumerable<Location> PassableNeighbors(Location id);
    }
}
