using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Dinosaur : Reptile
    {
        public string Food { get; set; }
        public override string Species { get; set; }
        public override string Reproduce { get; set; }

        public Dinosaur(string species, bool extinct, string reproduce, bool scale, string food) : base(species, extinct, reproduce, scale)
        {
            Food = food;
        }

        public override void Eat()
        {
            Console.WriteLine($"I eat {Food}");
        }

        public override string Sound()
        {
            return "RAWWWWWWWWWWRKAWKAW";
        }

        public override string Fly(bool canFly)
        {
            if (canFly)
            {
                return "I can flyyy";
            }
            else
            {
                return "I can't fly but I can either run";
            }
        }
    }
}
