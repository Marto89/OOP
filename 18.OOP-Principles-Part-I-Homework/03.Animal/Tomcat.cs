using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animal
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
            : base(age, name, Gender.Male) { }
        public override string ProduceSound()
        {
            return string.Format("***Tomcat say :Miauuuu***");
        }
    }
}
