using System;
using System.Collections.Generic;
using System.Text;

namespace NidaGameProject
{
    interface IPlayerService
    {
        void NewPlayerRegistration(Player player);
        void DeletePlayerRegistration(Player player);
        void UpdatePlayerInfo(Player player);
    }
}
