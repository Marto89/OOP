using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animal
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name)
            : base(age, name, Gender.Female) { }
        public override string ProduceSound()
        {
            return string.Format("***Kitten say:Miauuuu***");
        }
    }
}
