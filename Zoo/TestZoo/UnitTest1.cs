using Zoo.Classes;
using System;
using Xunit;

namespace TestZoo
{
    public class UnitTest1
    {
        Bear polarBear = new Bear("Polar Bear", false, "Birth", true, "White");
        Tiger siberianTiger = new Tiger("Siberian Tiger", false, "Birth", true, "Siberia");
        Elephant elephant = new Elephant("Dumbo", false, "Birth", true, 2);
        Dinosaur tRex = new Dinosaur("T-Rex", true, "Egg", true, "Other dinosaur");
        Bird ostrich = new Bird("Ostrich", false, "Egg", false, "Hmm");

        [Fact]
        public void BearOne()
        {
            Assert.False(polarBear.Extinct);
        }
        [Fact]
        public void BearTwo()
        {
            Assert.Equal("I go RAWR", polarBear.Sound());
        }
        [Fact]
        public void TigerOne()
        {
            Assert.False(siberianTiger.Extinct);
        }
        [Fact]
        public void TigerTwo()
        {
            Assert.Equal("I go PURRRR", siberianTiger.Sound());
        }
        [Fact]
        public void ElephantOne()
        {
            Assert.Equal("Dumbo", elephant.Species);
        }
        [Fact]
        public void ElephantTwo()
        {
            Assert.Equal("My voice is ....", elephant.Sound());
        }
        [Fact]
        public void DinosaurOne()
        {
            Assert.True(tRex.Extinct);
        }
        [Fact]
        public void DinosaurTwo()
        {
            Assert.Equal("T-Rex", tRex.Species);
        }
        [Fact]
        public void BirdOne()
        {
            Assert.Equal("I can't fly but I can run", ostrich.Fly(false));
        }
        [Fact]
        public void BirdTwo()
        {
            Assert.False(ostrich.Extinct);
        }

        [Fact]
        public void TigerInterface()
        {
            Assert.Equal("I can swim so good", siberianTiger.Swim());
        }
        [Fact]
        public void BearInterfaceOne()
        {
            Assert.Equal("I swimmmmmm", polarBear.Swim());
        }
        [Fact]
        public void BearInterfaceTwo()
        {
            Assert.Equal("This fur keeps me warm :D", polarBear.KeepWarm(polarBear.HasFur));
        }
        [Fact]
        public void ProvingMethodHasBeenOverridden()
        {
            Assert.NotEqual("My voice is ....", siberianTiger.Sound());
        }
        [Fact]
        public void ProvingConcreteAnimalIsAnAnimal()
        {
            Assert.True(siberianTiger is Animal);
        }
    }
}