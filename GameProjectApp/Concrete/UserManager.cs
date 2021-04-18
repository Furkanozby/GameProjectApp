using GameProjectApp.Abstract;
using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Concrete
{
    class UserManager :BaseUserManager
    {
        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            this._userCheckService = userCheckService;
        }
    }
}
