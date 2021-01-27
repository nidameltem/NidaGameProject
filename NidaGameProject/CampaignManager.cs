using System;
using System.Collections.Generic;
using System.Text;

namespace NidaGameProject
{
    class CampaignManager : ICampaignService
    {
        public void NewCampaignEntry(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı oyunda dünya oyun gününe özel %50 indirim var.");
            Console.WriteLine("Oyunun indirimli fiyatı :" + game.GamePrice/2);

        }
        public void DeleteCampaign(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı oyundaki kampanyamız sona ermiştir");
        }

        public void UpdateCampaign(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı oyunda dünya oyun gününe özel indirim güncellendi");
            
        }

  
     

       
    }
}
