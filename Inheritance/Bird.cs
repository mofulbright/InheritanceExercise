using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {

        }

        public bool CanFly { get; set; }
        public bool IsSmall { get; set; }
        public bool IsScavenger { get; set; }
        public bool Migrates { get; set; }
    }
}
