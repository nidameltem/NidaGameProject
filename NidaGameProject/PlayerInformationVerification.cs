using System;
using System.Collections.Generic;
using System.Text;

namespace NidaGameProject
{
    class PlayerInformationVerification
    {
        public void PlayerControl(Player player,EDevletPlayerInformation eDevletPlayerInformation)
        {
            if (player.PlayerAd == eDevletPlayerInformation.EDevletPlayerAd)
            {
                Console.WriteLine("Oyuncu adı eşleşti.");
            }
            else
            {
                Console.WriteLine("Eşleşme Hatalı!");
            }
            if (player.PlayerSoyad== eDevletPlayerInformation.EDevletPlayerSoyad)
            {
                Console.WriteLine("Oyuncu soyadı eşleşti.");
            }
            else
            {
                Console.WriteLine("Eşleşme Hatalı!");
            }
            if (player.TcNo==eDevletPlayerInformation.EDevletTcNo)
            {
                Console.WriteLine("Oyuncu TcNo eşleşti.");
            }
            else
            {
                Console.WriteLine("Eşleşme Hatalı!");
            }
            if (player.PlayerBirthday == eDevletPlayerInformation.EDevletPlayerBirthday)
            {
                Console.WriteLine("Oyuncu doğum tarihi eşleşti.");
            }
            else
            {
                Console.WriteLine("Eşleşme Hatalı!");
            }


        }
    }
}
