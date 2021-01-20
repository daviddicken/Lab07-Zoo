using System;
using System.Collections.Generic;
using System.Text;


namespace Zoo
{
    public abstract class Mammal : Animal
    {
        public abstract bool IsSolitary { get; set; }
        public abstract bool IsMatriarchal { get; set; }
    }
}
