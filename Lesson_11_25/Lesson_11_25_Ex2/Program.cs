/* Ստեղծիր բազային դաս Animal․
● Property Name
● Virtual մեթոդ Speak() → տպում "Animal sound"
Ստեղծիր derived դասեր․
● Dog → override Speak() → տպում "Woof!"
● Cat → override Speak() → տպում "Meow!"
● Cow → override Speak() → տպում "Moo!"
Գրիր ծրագիր, որը պահում է Animal[] զանգված և loop‑ով կանչում է բոլորի Speak() մեթոդները*/

using System;
namespace Ex2
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound");
        }
    }
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }
    public class Cow : Animal
    {
        public Cow(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine("Moo!");
        }
    }
    public class Program
    {
        static void Main()
        {
            Animal[] animals =
        {
            new Dog("Dog"),
            new Cat("Cat "),
            new Cow("Cow")
        };

            foreach (Animal a in animals)
            {
                Console.Write($"{a.Name}: ");
                a.Speak();
            }

        }
    }
}
