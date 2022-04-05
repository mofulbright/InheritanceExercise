using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        {

        }

        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool CanRegenerateTail { get; set; }
        public bool IsAPredator { get; set; }
    }
}
