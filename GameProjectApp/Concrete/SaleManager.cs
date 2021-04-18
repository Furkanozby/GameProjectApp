using GameProjectApp.Abstract;
using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sale(Game game, User user, Campaign campaign)
        {
            Console.WriteLine(user.FirstName+" Adlı Kullanıcı:"+game.GameName+campaign.CampaignName+" Adlı oyunu"+" adlı kampanya ile satın aldı.");
        }
    }
}
