using GameProjectHomerwork2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomerwork2.Interfaces
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        void ApplyCampaign(Games game, Campaign campaign);
    }
}
