using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Monkey : Mammal
    {
        public override bool IsSolitary { get; set; } = false;
        public override bool IsMatriarchal { get; set; } = false;
        public override bool LivesInWater { get; set; } = false;
        public override bool IsEndangered { get; set; } = false;
        public override int Weight { get; set; } = 30;
        public override string Diet { get; set; } = "Bananas";
        public override bool IsNocturnal { get; set; } = false;

        public override string Sound()
        {
            return "Screaming";
        }
        public override string Eat(string meal)
        {
            if (meal == Diet) return "Yum Yum";
            return "Food fight!!";
        }
    }
}
