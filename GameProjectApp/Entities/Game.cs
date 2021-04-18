using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectApp.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public long Price { get; set; }
        public string Category { get; set; }
        public int UnitsInStock { get; set; }
    }
}
