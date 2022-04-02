using Zoo.Classes;
using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear polarBear = new Bear("Polar Bear", false, "Birth", true, "White");
            Tiger siberianTiger = new Tiger("Siberian Tiger", false, "Birth", true, "Siberia");
            Elephant elephant = new Elephant("Dumbo", false, "Birth", true, 2);
            Dinosaur tRex = new Dinosaur("T-Rex", true, "Egg", true, "Other dinosaur");
            Bird ostrich = new Bird("Ostrich", false, "Egg", false, "Hmm");

            polarBear.SpeicesIntro();
            Console.WriteLine(polarBear.Sound());
            Console.WriteLine("");

            siberianTiger.SpeicesIntro();
            Console.WriteLine(siberianTiger.Swim());
            Console.WriteLine("");

            elephant.SpeicesIntro();
            elephant.Eat();
            Console.WriteLine("");

            tRex.SpeicesIntro();
            Console.WriteLine("I probably sounded like " + tRex.Sound());
            Console.WriteLine("");

            ostrich.SpeicesIntro();
            Console.WriteLine(ostrich.Fly(false));
            Console.WriteLine("");
        }
    }
}