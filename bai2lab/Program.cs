using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2lab
{
    internal class Program
    {
        
        // Animal abstract class
        public abstract class Animal
        {
            protected string type;

            public Animal(string type)
            {
                this.type = type;
            }

            public abstract string MakeSound();

            public abstract string GetInfo();
        }

        // Dog class
        public class Dog : Animal
        {
            private string breed;
            public string Name { get; set; }

            public Dog(string type, string name, string breed) : base(type)
            {
                this.Name = name;
                this.breed = breed;
            }

            public override string MakeSound()
            {
                return "Gau Gau!";
            }

            public override string GetInfo()
            {
                return $"Type: {type}, Name: {Name}, Breed: {breed}";
            }
        }

        // Cat class
        public class Cat : Animal
        {
            public string Name { get; set; }

            public Cat(string type, string name) : base(type)
            {
                this.Name = name;
            }

            public override string MakeSound()
            {
                return "Meow!";
            }

            public override string GetInfo()
            {
                return $"Type: {type}, Name: {Name}";
            }

            public void Climb(string thing)
            {
                Console.WriteLine($"{Name} is climbing {thing}");
            }
        }

        // Duck class
        public class Duck : Animal
        {
            public string Name { get; set; }

            public Duck(string type, string name) : base(type)
            {
                this.Name = name;
            }

            public override string MakeSound()
            {
                return "Cap. cap.!";
            }

            public override string GetInfo()
            {
                return $"Type: {type}, Name: {Name}";
            }

            public void Swim(string thing)
            {
                Console.WriteLine($"{Name} is swimming in {thing}");
            }
        }

        static void Main(string[] args)
        {
            Dog myDog = new Dog("mammal", "Susan", "Collie");
            Console.WriteLine(myDog.GetInfo());
            Console.WriteLine(myDog.MakeSound());

            Cat myCat = new Cat("mammal", "Meoden");
            Console.WriteLine(myCat.GetInfo());
            Console.WriteLine(myCat.MakeSound());
            myCat.Climb("wall");

            Duck myDuck = new Duck("bird", "DuckDuck");
            Console.WriteLine(myDuck.GetInfo());
            Console.WriteLine(myDuck.MakeSound());
            myDuck.Swim("pool");

            Console.ReadLine();
        }
    }
}
