using GameProjectHomerwork2.Entities;
using GameProjectHomerwork2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomerwork2.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sell(Player player, Games games, Campaign campaign)
        {
            games.NewPrice = games.GamePrice - (games.GamePrice * (campaign.CampaingDiscount / 100));
            Console.WriteLine("SİPARİŞ DETAYLARI " + "\nAd Soyad: " + player.Ad + " " + player.Soyad + "\nOyuncu numarası: " + player.Id + " \n" + games.GameName + " adlı oyunu satın almıştır. \n" + campaign.CampaingName + " kampanyasından faydalanmıştır. \n" + "Uygulanan indirim sonucu sepet tutarı: " + "#" + games.NewPrice + "TL" + "#");



        }
    }
}
