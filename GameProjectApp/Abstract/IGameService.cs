using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
