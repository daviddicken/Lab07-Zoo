using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Crocodile : NonFlying
    {
        public override bool LivesInWater { get; set; } = true;
        public override bool IsEndangered { get; set; } = false;
        public override int Weight { get; set; } = 200;
        public override string Diet { get; set; } = "Fish";
        public override bool IsNocturnal { get; set; } = false;
       
        public override bool HasFeathers { get; set; } = false;

        public override string Sound()
        {
            return "Click...Click...Click";
        }

        public override string Movement()
        {
            return "Craawling";
        }
    }
}
