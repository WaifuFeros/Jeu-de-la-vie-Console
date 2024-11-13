using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_vie
{
    public class Grid
    {
        public int N {  get; set; }

        public Cell[,] TabCells;

        public Grid(int nbCells, List<Coords> AliveCellsCoords)
        {
            N = nbCells;
            TabCells = new Cell[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    bool isAlive = AliveCellsCoords.Contains(new Coords(i, j));
                    TabCells[i, j] = new Cell(isAlive);
                }
            }
        }

        public int GetNbAliveNeighboor(int i, int j)
        {
            var coords = GetCoordsNeighboors(i, j);

            int aliveCount = 0;
            foreach (var coord in coords)
            {
                if (TabCells[coord.X, coord.Y].IsAlive)
                    aliveCount++; ;
            }

            return aliveCount;
        }

        public List<Coords> GetCoordsNeighboors(int i, int j)
        {
            throw new NotImplementedException();
        }

        public List<Coords> GetCoordsCellsAlive()
        {
            throw new NotImplementedException();
        }

        public void DisplayGrid()
        {

        }

        public void UpdateGrid()
        {

        }
    }
}
