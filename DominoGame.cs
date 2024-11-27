using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingBeings
{
    using System.Collections.Generic;

    public class DominoGame
    {
        private List<Player> Players { get; }
        private Board GameBoard { get; }

        public DominoGame()
        {
            Players = new List<Player>();
            GameBoard = new Board();
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void StartGame()
        {
            // Логика начала игры
        }

        public void PlayTurn(Player player, int tileIndex)
        {
            DominoTile tile = player.PlayTile(tileIndex);
            GameBoard.PlaceTile(tile);
        }
    }
}
