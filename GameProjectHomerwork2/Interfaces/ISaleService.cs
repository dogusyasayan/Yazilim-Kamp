using GameProjectHomerwork2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomerwork2.Interfaces
{
    interface ISaleService
    {
        void Sell(Player player, Games games, Campaign campaign);
    }
}
