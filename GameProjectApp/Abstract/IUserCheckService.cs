using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
