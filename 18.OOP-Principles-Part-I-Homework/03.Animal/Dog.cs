using System;

namespace _03.Animal
{
    public class Dog : Animal
    {
        public Dog(int age, string name, Gender sex)
            : base(age, name, sex)
        {
        }
        public override string ProduceSound()
        {
            return string.Format("***Bauu***");
        }
    }
}
