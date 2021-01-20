using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo
{
    public class Penguin : NonFlying, IBirdShow, ISwim
    {
        public override bool LivesInWater { get; set; } = false;
        public override bool IsEndangered { get; set; } = false;
        public override int Weight { get; set; } = 40;
        public override string Diet { get; set; } = "Fish";
        public override bool IsNocturnal { get; set; } = false;
        public override bool HasFeathers { get; set; } = true;

        public override string Sound()
        {
            return "chirp chirp";
        }
        public override string Movement()
        {
            return "Waddle waddle";
        }

        public string Routine()
        {
            Console.WriteLine(Movement());
            Console.WriteLine(Sound());
            return "Take a bow";
        }

        public string Swim()
        {
            return "Dive for fish";
        }
    }
}
