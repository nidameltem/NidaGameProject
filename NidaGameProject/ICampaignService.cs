using System;
using System.Collections.Generic;
using System.Text;

namespace NidaGameProject
{
    interface ICampaignService
    {
        void NewCampaignEntry(Game game);
        void DeleteCampaign(Game game);
        void UpdateCampaign(Game game);
    }
}
