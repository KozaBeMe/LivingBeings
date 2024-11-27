using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingBeings
{
    using System.Collections.Generic;

    public class Player
    {
        public string Name { get; }
        private List<DominoTile> Hand { get; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<DominoTile>();
        }

        public void AddTile(DominoTile tile)
        {
            Hand.Add(tile);
        }

        public DominoTile PlayTile(int index)
        {
            var tile = Hand[index];
            Hand.RemoveAt(index);
            return tile;
        }
    }
}
