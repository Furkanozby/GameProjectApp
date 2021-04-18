using GameProjectApp.Abstract;
using GameProjectApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Concrete
{
    class UserCheckManager : BaseUserManager
    {
        IUserCheckService _userCheckService;

        public UserCheckManager(IUserCheckService userCheckService)
        {
            this._userCheckService = userCheckService;
        }

        public override void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.Add(user);
            }
            else
            {
                Console.WriteLine("Bilgilerinizi kontrol ediniz.");
            }
            
        }
    }
}
