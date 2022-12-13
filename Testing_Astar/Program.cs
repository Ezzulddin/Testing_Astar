using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Astar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SquareGrid grid = new SquareGrid(6, 10);
            
            grid.walls.Add(new Location(10 - 1, 1 - 1));

            
            grid.walls.Add(new Location(2 - 1, 2 - 1));
            grid.walls.Add(new Location(3 - 1, 2 - 1));
            grid.walls.Add(new Location(4 - 1, 2 - 1));
            grid.walls.Add(new Location(5 - 1, 2 - 1));
            grid.walls.Add(new Location(6 - 1, 2 - 1));
            grid.walls.Add(new Location(7 - 1, 2 - 1));
            grid.walls.Add(new Location(8 - 1, 2 - 1));
            grid.walls.Add(new Location(10 - 1, 2 - 1));

           
            grid.walls.Add(new Location(2 - 1, 3 - 1));
            grid.walls.Add(new Location(7 - 1, 3 - 1));
            grid.walls.Add(new Location(10 - 1, 3 - 1));

            
            grid.walls.Add(new Location(4 - 1, 4 - 1));
            grid.walls.Add(new Location(5 - 1, 4 - 1));
            grid.walls.Add(new Location(7 - 1, 4 - 1));

            
            grid.walls.Add(new Location(1 - 1, 5 - 1));
            grid.walls.Add(new Location(2 - 1, 5 - 1));
            grid.walls.Add(new Location(3 - 1, 5 - 1));
            grid.walls.Add(new Location(4 - 1, 5 - 1));
            grid.walls.Add(new Location(5 - 1, 5 - 1));
            grid.walls.Add(new Location(7 - 1, 5 - 1));
            grid.walls.Add(new Location(8 - 1, 5 - 1));
            grid.walls.Add(new Location(9 - 1, 5 - 1));

            
            grid.walls.Add(new Location(1 - 1, 6 - 1));
            grid.walls.Add(new Location(2 - 1, 6 - 1));
            grid.walls.Add(new Location(3 - 1, 6 - 1));
            grid.walls.Add(new Location(4 - 1, 6 - 1));
            grid.walls.Add(new Location(5 - 1, 6 - 1));

            
            Location startingLocation = new Location(0, 0);

            
            Location endingLocation = new Location(5, 5);

            
            AstarSearch aStar = new AstarSearch(grid);
            aStar.CalculatePath(startingLocation, endingLocation);

            
            DrawGride(grid, aStar);

            Console.ReadLine();
        }
        public static void DrawGride(SquareGrid grid, AstarSearch aStar)
        {
            for (int row = 0; row < grid.Rows; row++)
            {
                for (int column = 0; column < grid.Columns; column++)
                {
                    Location cell = new Location(column, row);

                    if (cell == aStar.Start)
                    {
                        Console.Write("S ");
                    }
                    else if (cell == aStar.Goal)
                    {
                        Console.Write("G ");
                    }
                    else if (grid.walls.Contains(cell))
                    {
                        Console.Write("# ");
                    }
                    else if (aStar.Path.Contains(cell))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
