using System;
using System.Collections.Generic;
using System.Text;

namespace NidaGameProject
{
    class GameSaleManager
    {
        public void GameSale(Player player,Game game)
        {
            Console.WriteLine(player.PlayerAd+" adlı oyuncu "+game.GameName+" adlı oyunu satın aldı.");
        }
    }
}
