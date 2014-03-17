using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animal
{
    public class Cat : Animal
    {
        public Cat(int age, string name, Gender sex)
            : base(age, name, sex) { }
        public override string ProduceSound()
        {
            return string.Format("***Miauuuuu***");
        }
    }
}
