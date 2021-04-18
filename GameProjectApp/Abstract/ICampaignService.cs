using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
