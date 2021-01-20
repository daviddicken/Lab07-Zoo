using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{

    /// <summary>
    /// Animal class is an abstact class that all other classes in the zoo are derived from.
    /// It has to virtual methods "Eat and Sleep" and a abstract method "Sound"
    /// Also has 5 abstract properties and 2 virtual properties
    /// </summary>
    public abstract class Animal
    {
        public abstract bool LivesInWater { get; set; }
        public abstract bool IsEndangered { get; set; }
        public virtual bool BreathesAir { get; set; } = true;
        public abstract int Weight { get; set; }
        public abstract String Diet { get; set; }
        public abstract bool IsNocturnal { get; set; }
        public virtual bool DoesFly { get; set; } = false;

        /// <summary>
        /// The Eat method takes in a string "meal" and compares it with the animals diet. returning "Yum Yum" if a match is found and "Not Hungry" if they are not a match
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public virtual string Eat(string meal)
        {
            if (meal == Diet) return "Yum Yum";
            return "Not Hungry";
        }

        /// <summary>
        /// The sleep Sleep method gets the current time for the users computer then
        /// checks if the animal is nocturnal or not depending on the reult it
        /// will compare the current hour and return a bool if the animal is asleep or not
        /// </summary>
        /// <returns></returns>
        public virtual bool Sleep()
        {
            DateTime time = DateTime.Now;
            int hour = time.Hour;

            if (!IsNocturnal) 
            {
                if(hour > 20 || hour < 4) return true;
                return false;
            }
            else
            {
                if (hour > 20 || hour < 4) return false;
                return true;
            }
            
        }
        /// <summary>
        /// Sound is a abstract method that is handled at the concrete level
        /// </summary>
        /// <returns></returns>
        public abstract string Sound();
    }
}
