using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo
{
    public class Flamingo : Flying, IBirdShow
    {
        public override bool LivesInWater { get; set; } = false;
        public override bool IsEndangered { get; set; } = false;
        public override int Weight { get; set; } = 45;
        public override string Diet { get; set; } = "Shrimp";
        public override bool IsNocturnal { get; set; } = false;
        public override bool HasFeathers { get; set; } = true;

        public string Routine()
        {
            return "Stand on one leg and look pretty!";
        }

        public override string Sound()
        {
            return "Honk Honk";
        }

    }
}
