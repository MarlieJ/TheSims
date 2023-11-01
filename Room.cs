using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Room
    {
        public string Name { get; private set; }
        public List<Furniture> Furnitures { get; private set; }
        public Room(string name)
        {
            Name = name;
        }
    }
}
