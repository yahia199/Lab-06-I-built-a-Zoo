using System;
namespace Zoo.Classes
{
    public abstract class Animal
    {
        public abstract string Species { get; set; }
        public virtual bool Extinct { get; set; }
        public abstract string Reproduce { get; set; }

        public Animal(string species, bool extinct, string reproduce)
        {
            Species = species;
            Extinct = extinct;
            Reproduce = reproduce;
        }

        abstract public void Eat();
        virtual public void SpeicesIntro()
        {
            Console.WriteLine($"I am {Species}");
        }
        virtual public string Sound()
        {
            return "My voice is ....";
        }
    }
}