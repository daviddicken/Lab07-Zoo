using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Eel : Fish
    {
        public override bool IsEndangered { get; set; } = false;
        public override int Weight { get; set; } = 7;
        public override string Diet { get; set; } = "Fish";
        public override bool IsNocturnal { get; set; } = true;
    }
}
