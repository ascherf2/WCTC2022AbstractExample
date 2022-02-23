using System;

namespace AbstractExample.Models
{
    public class Cow : Animal
    {


        public Cow(string name)
        {
            Name = name;
        }

        public Cow()
        {
            Name = "George";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says moooooooo");

        }
        public override void Sleep()
        {
            Console.WriteLine($"ZZZZzzzzz");
        }
    }
}
    
