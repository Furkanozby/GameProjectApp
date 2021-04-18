using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Abstract
{
    interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
