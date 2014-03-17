/*
 * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/
using System;

namespace _03.Animal
{
    class TestAnimal
    {
        static Animal[] Animals(Animal[] animals)
        {
            animals[0] = new Dog(5, "Sharo", Gender.Male);
            animals[1] = new Frog(4, "Goshko", Gender.Male);
            animals[2] = new Tomcat(7, "Tom");
            animals[3] = new Kitten(2, "Lora");
            animals[4] = new Cat(10, "Mima", Gender.Female);
            animals[5] = new Dog(3, "Djaro", Gender.Male);
            return animals;
        }
        static Animal[] Animals2(Animal[] animals)
        {

            animals[0] = new Dog(10, "Lassie", Gender.Female);
            animals[1] = new Dog(15, "Sharo", Gender.Male);
            animals[2] = new Dog(40, "Murdjo", Gender.Male);
            animals[3] = new Dog(20, "Bethoven", Gender.Male);
            animals[4] = new Dog(2, "Kiki", Gender.Male);

            return animals;
        }
        static void Main()
        {
            Animal[] animals = new Animal[6];
            Animal[] dogs = new Animal[5];
            Animals(animals);
            Animals2(dogs);

            foreach (var n in animals)
            {
                Console.Write(n.ToString());
                Console.WriteLine(n.ProduceSound());
            }
            Console.WriteLine("Average age of mixed animals is:{0:F2} years!", Animal.AverageAge(animals));
            Console.WriteLine(new string('-', 80));
            foreach (var n in dogs)
            {
                Console.Write(n.ToString());
                Console.WriteLine(n.ProduceSound());
            }
            Console.WriteLine("Average age of dogs is:{0:F2} years!", Animal.AverageAge(dogs));

        }
    }
}
