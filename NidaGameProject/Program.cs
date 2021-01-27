using System;
using System.Collections.Generic;

namespace NidaGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.PlayerAd = "Nida";
            player1.PlayerSoyad = "Meltem";
            player1.TcNo = "245196";
            player1.PlayerBirthday = "29 Mayıs 1995";

            Player player2 = new Player();
            player2.PlayerAd = "Eda";
            player2.PlayerSoyad = "Dilara";
            player2.TcNo = "24519652";
            player2.PlayerBirthday = "29 Mayıs 1999";

            EDevletPlayerInformation eDevletPlayerInformation1 = new EDevletPlayerInformation();
            eDevletPlayerInformation1.EDevletPlayerAd = "Nida";
            eDevletPlayerInformation1.EDevletPlayerSoyad = "Melte";
            eDevletPlayerInformation1.EDevletTcNo = "245196";
            eDevletPlayerInformation1.EDevletPlayerBirthday = "29 Mayıs 1995";

            Game game1 = new Game();
            game1.GameName = "Titanic";
            game1.GamePrice = 54;

            Game game2 = new Game();
            game2.GameName = "Tetris";
            game2.GamePrice = 25;


            ICampaignService campaignManager = new CampaignManager();
            campaignManager.NewCampaignEntry(game1);
            campaignManager.DeleteCampaign(game1);
            campaignManager.UpdateCampaign(game1);

            Console.WriteLine("*************************");

            IPlayerService playerManager = new PlayerManager();
            playerManager.NewPlayerRegistration(player1);
            playerManager.DeletePlayerRegistration(player1);
            playerManager.UpdatePlayerInfo(player1);

            Console.WriteLine("*************************");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.GameSale(player1, game2);

            Console.WriteLine("*************************");

            PlayerInformationVerification playerInformationVerification = new PlayerInformationVerification();
            playerInformationVerification.PlayerControl(player1,eDevletPlayerInformation1);

        }
    }
}
