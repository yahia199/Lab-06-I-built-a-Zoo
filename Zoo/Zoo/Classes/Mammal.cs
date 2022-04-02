using System;
using Zoo;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Mammal : Animal , IKeepWarm
    {
        public bool HasFur { get; set; }
        public virtual bool Lactate { get; set; } = true;
        public Mammal(string species, bool extinct, string reproduce, bool fur) : base(species, extinct, reproduce)
        {
            HasFur = fur;
        }

        abstract public void Hibernate();
        public virtual void Hunt()
        {
            Console.WriteLine("Where is my food?");
        }

        public string KeepWarm(bool fur)
        {
            return "This fur keeps me warm :D";
        }
    }
}