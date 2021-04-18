using System;
using System.Collections.Generic;
using System.Text;
using GameProjectApp.Entities;

namespace GameProjectApp.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Add(User user)
        {
            Console.WriteLine("Added to : "+user.FirstName +" "+user.LastName);
        }

        public void Delete(User user)
        {
            Console.WriteLine("Deleted to : " + user.FirstName + " " + user.LastName);
        }

        public void Update(User user)
        {
            Console.WriteLine("Updated to : " + user.FirstName + " " + user.LastName);
        }
    }
}
