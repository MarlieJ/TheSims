using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Floor
    {
        public int FloorNumber { get; private set; }
        public List<Room> Rooms { get; private set; }
        public Floor(int floornumber)
        {
            FloorNumber = floornumber;
        }
    }
}
