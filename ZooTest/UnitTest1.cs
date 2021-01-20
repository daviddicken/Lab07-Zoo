using System;
using Xunit;
using Zoo;

namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestWhale()
        {
            // Test that a whale is a Animal
            Whale Willy = new Whale();
            Assert.True(Willy is Animal animal);

            // Test that Willy inherited and can use the sleep method
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if(hour > 20 || hour < 4)
            {
                Assert.True(Willy.Sleep());
            }else
            {
                Assert.False(Willy.Sleep());
            }

            // Test that Willy inherited and can use the eat method
            Assert.Equal("Yum Yum", Willy.Eat("Plankton"));
            Assert.Equal("Not Hungry", Willy.Eat("Veggies"));

            // Test that Whale inherited IsSolitary from the Mammal class
            Assert.True(Willy.IsSolitary);

            // Test that Willy can implement the swim interface
            Assert.Equal("Breach... Splash the crowd", Willy.Swim());
        }

        [Fact]
        public void TestLion()
        {
            Lion Willy = new Lion();
            Assert.True(Willy is Animal animal);

            // Test that Willy inherited and can use the sleep method
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour > 20 || hour < 4)
            {
                Assert.False(Willy.Sleep());
            }
            else
            {
                Assert.True(Willy.Sleep());
            }

            Assert.Equal("Yum Yum", Willy.Eat("Meat"));
            Assert.Equal("Not Hungry", Willy.Eat("Veggies"));
        }

        [Fact]
        public void TestMonkey()
        {
            Monkey Willy = new Monkey();
            Assert.True(Willy is Animal animal);

            // Test that Willy inherited and can use the sleep method
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour > 20 || hour < 4)
            {
                Assert.True(Willy.Sleep());
            }
            else
            {
                Assert.False(Willy.Sleep());
            }

            // Test that Monkey overroad the eat method
            Assert.Equal("Yum Yum", Willy.Eat("Bananas"));
            Assert.Equal("Food fight!!", Willy.Eat("Veggies"));
        }

        [Fact]
        public void TestCrocodile()
        {
            Crocodile Willy = new Crocodile();
            Assert.True(Willy is Animal animal);

            // Test that Willy inherited and can use the sleep method
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour > 20 || hour < 4)
            {
                Assert.True(Willy.Sleep());
            }
            else
            {
                Assert.False(Willy.Sleep());
            }

            Assert.Equal("Yum Yum", Willy.Eat("Fish"));
            Assert.Equal("Not Hungry", Willy.Eat("Veggies"));
        }

        [Fact]
        public void TestPenguin()
        {
            Penguin Willy = new Penguin();
            Assert.True(Willy is Animal animal);

            // Test that Willy inherited and can use the sleep method
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour > 20 || hour < 4)
            {
                Assert.True(Willy.Sleep());
            }
            else
            {
                Assert.False(Willy.Sleep());
            }

            Assert.Equal("Yum Yum", Willy.Eat("Fish"));
            Assert.Equal("Not Hungry", Willy.Eat("Veggies"));


            // Test that Willy can implement the swim interface
            // That Willy is in the bird show interface
            Assert.Equal("Dive for fish", Willy.Swim());
            Assert.Equal("Take a bow", Willy.Routine());

        }

        [Fact]
        public void TestFlamingo()
        {
            Flamingo Willy = new Flamingo();
            Assert.True(Willy is Animal animal);

            // Test that Willy inherited and can use the sleep method
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour > 20 || hour < 4)
            {
                Assert.True(Willy.Sleep());
            }
            else
            {
                Assert.False(Willy.Sleep());
            }

            Assert.Equal("Yum Yum", Willy.Eat("Shrimp"));
            Assert.Equal("Not Hungry", Willy.Eat("Veggies"));

            // That Willy is in the bird show interface
            Assert.Equal("Stand on one leg and look pretty!", Willy.Routine());
        }

        [Fact]
        public void TestLungFish()
        {
            LungFish Willy = new LungFish();
            Assert.True(Willy is Animal animal);

            // Test that Willy inherited and can use the sleep method
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour > 20 || hour < 4)
            {
                Assert.True(Willy.Sleep());
            }
            else
            {
                Assert.False(Willy.Sleep());
            }

            Assert.Equal("Yum Yum", Willy.Eat("Worms"));
            Assert.Equal("Not Hungry", Willy.Eat("Veggies"));

            // Test that LungFish inherited and can implement the swim interface
            Assert.Equal("Dart this way, Dart that way", Willy.Swim());
        }

        [Fact]
        public void TestEel()
        {
            Eel Willy = new Eel();
            Assert.True(Willy is Animal animal);

            // Test that Willy inherited and can use the sleep method
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour > 20 || hour < 4)
            {
                Console.WriteLine("enter if part of noct test");
                Assert.False(Willy.Sleep());
            }
            else
            {
                Console.WriteLine("enter else part of noct test");

                Assert.True(Willy.Sleep());
            }

            Assert.Equal("Yum Yum", Willy.Eat("Fish"));
            Assert.Equal("Not Hungry", Willy.Eat("Veggies"));

            // Test that Eel inherited and can implement the swim interface
            Assert.Equal("Dart this way, Dart that way", Willy.Swim());
        }
    }
}
