using GameProjectApp.Abstract;
using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Eklenen Kampanya : "+campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Silinen Kampanya : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Güncellenen Kampanya : " + campaign.CampaignName);
        }
    }
}
