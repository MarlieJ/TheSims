using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Character
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Character(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
