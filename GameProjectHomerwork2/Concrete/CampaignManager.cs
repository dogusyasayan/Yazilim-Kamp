using GameProjectHomerwork2.Entities;
using GameProjectHomerwork2.Interfaces;
using GameProjectHomerwork2.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomerwork2.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " adlı kampanya eklendi. İndirim oranı: " + campaign.CampaingDiscount);
        }

        public void ApplyCampaign(Games game, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " adlı kampanya " + game.GameName + " adlı oyuna uygulandı. \n İndirim uygulanmış sepet tutarı: " + game.GamePrice);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " adlı kampanya sistemden silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " adlı kampanya güncellendi. Güncel indirim oranı: " + campaign.CampaingDiscount);
        }
    }
}
