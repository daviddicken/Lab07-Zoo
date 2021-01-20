using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class LungFish : Fish
    {
        public override bool BreathesAir { get; set; } = true;
        public override bool IsEndangered { get; set; } = false;
        public override int Weight { get; set; } = 5;
        public override string Diet { get; set; } = "Worms";
        public override bool IsNocturnal { get; set; } = false;
    }
}
