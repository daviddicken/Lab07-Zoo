using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo
{
    public class Whale : Mammal, ISwim
    {
        public override bool IsSolitary { get; set; } = true;
        public override bool IsMatriarchal { get; set; } = true;
        public override bool LivesInWater { get; set; } = true;
        public override bool IsEndangered { get; set; } = true;
        public override int Weight { get; set; } = 2000;
        public override string Diet { get; set; } = "Plankton";
        public override bool IsNocturnal { get; set; } = false;

        public override string Sound()
        {
            return "Singing.....La La La";
        }

        public string Swim()
        {
            return "Breach... Splash the crowd";
        }
    }
}
