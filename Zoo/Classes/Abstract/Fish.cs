using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo
{
    public abstract class Fish : Animal, ISwim
    {
        public override bool BreathesAir { get; set; } = false;
        public override bool LivesInWater { get; set; } = true;

        public override string Sound()
        {
            return "Bubble, Bubble";
        }

        public string Swim()
        {
            return "Dart this way, Dart that way";
        }
    }
}
