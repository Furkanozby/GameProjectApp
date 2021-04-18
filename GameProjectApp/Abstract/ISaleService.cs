using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Abstract
{
    interface ISaleService
    {
        void Sale(Game game, User user,Campaign campaign);
    }
}
