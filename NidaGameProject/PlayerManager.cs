using System;
using System.Collections.Generic;
using System.Text;

namespace NidaGameProject
{
    class PlayerManager : IPlayerService
    {
        public void NewPlayerRegistration(Player player)
        {
            Console.WriteLine(player.PlayerAd+" Adlı oyuncunun kaydı başarıyla tamamlandı.");
        }

        public void DeletePlayerRegistration(Player player)
        {
            Console.WriteLine(player.PlayerAd+" Adlı oyuncunun kaydı başarıyla silindi.");
        }

        public void UpdatePlayerInfo(Player player)
        {
            Console.WriteLine(player.PlayerAd+ " Adlı oyuncunun bilgileri güncellendi");
            
        }


    }
}
