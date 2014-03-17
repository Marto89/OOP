using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animal
{
    public enum Gender
    {
        Female, Male
    }
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Gender animalGender;
        public Animal(int age, string name, Gender animalGender)
        {
            this.Age = age;
            this.Name = name;
            this.AnimalGender = animalGender;
        }
        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public Gender AnimalGender
        {
            get { return this.animalGender; }
            private set { this.animalGender = value; }
        }

        public virtual string ProduceSound()
        {
            return string.Format(this.GetType().Name + "Say smth.");
        }
        public override string ToString()
        {
            return string.Format("I'm a {3} {0}!My name is {1}.I'm {2} years old.", this.GetType().Name, this.Name, this.Age, this.AnimalGender);
        }
        public static double AverageAge(Animal[] animals)
        {
            var averageAge = animals.Average(animal => animal.Age);
            return averageAge;
        }
    }
}
