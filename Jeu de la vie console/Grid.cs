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

        }

        public int GetNbAliveNeighboor(int i, int j)
        {
            throw new NotImplementedException();
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
