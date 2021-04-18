using GameProjectApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfYear { get; set; }
        public string NationalityId { get; set; }
    }
}
