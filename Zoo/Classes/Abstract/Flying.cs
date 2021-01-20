using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Flying : Reptiles
    {
        public override bool DoesFly { get; set; } = true;
       
    }
}
