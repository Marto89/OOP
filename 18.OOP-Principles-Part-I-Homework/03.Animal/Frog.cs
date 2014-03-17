using System;

namespace _03.Animal
{
    public class Frog : Animal
    {
        public Frog(int age, string name, Gender sex)
            : base(age, name, sex) { }
        public override string ProduceSound()
        {
            return string.Format("***Krqk***");
        }
    }
}
