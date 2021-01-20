using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Lion : Mammal
    {
        public override bool IsSolitary { get; set; } = false;
        public override bool IsMatriarchal { get; set; } = false;
        public override bool LivesInWater { get; set; } = false;
        public override bool IsEndangered { get; set; } = false;
        public override int Weight { get; set; } = 700;
        public override string Diet { get; set; } = "Meat";
        public override bool IsNocturnal { get; set; } = true;

        public override string Sound()
        {
            return "Roooar";
        }
    }
}
