using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingBeings
{
    using System.Collections.Generic;

    public class Board
    {
        private List<DominoTile> Tiles { get; }

        public Board()
        {
            Tiles = new List<DominoTile>();
        }

        public void PlaceTile(DominoTile tile)
        {
            Tiles.Add(tile);
        }

        public List<DominoTile> GetTiles()
        {
            return Tiles;
        }
    }
}
