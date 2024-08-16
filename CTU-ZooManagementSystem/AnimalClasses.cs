using System;

namespace CTU_ZooManagementSystem
{
    public enum AnimalType
    {
        Mammal,
        Bird,
        Reptile,
        Elephant,
        Crocodile,
        Eagle
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract string Speak();
        public abstract string Move();
    }

    public class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age) { }

        public override void Eat()
        {
            // Implementation of Eat method for Lion
            Console.WriteLine("Lion is eating a piece of Zebra meat.");
        }

        public override void Sleep()
        {
            // Implementation of Sleep method for Lion
            Console.WriteLine("Lion is sleeping in its den.");
        }

        public override string Speak()
        {
            return "Roar!";
        }

        public override string Move()
        {
            return "Lion is walking onto a rock.";
        }
    }

    public class Parrot : Animal
    {
        public Parrot(string name, int age) : base(name, age) { }

        public override void Eat()
        {
            // Implementation of Eat method for Parrot
            Console.WriteLine("Parrot is eating seeds.");
        }

        public override void Sleep()
        {
            // Implementation of Sleep method for Parrot
            Console.WriteLine("Parrot is sleeping on its perch.");
        }

        public override string Speak()
        {
            return "Squawk!";
        }

        public override string Move()
        {
            return "The Parrot is flying from tree to tree.";
        }
    }


    public class Turtle : Animal
    {
        public Turtle(string name, int age) : base(name, age) { }

        public override void Eat()
        {
            // Implementation of Eat method for Turtle
            Console.WriteLine("Turtle is eating vegetation.");
        }

        public override void Sleep()
        {
            // Implementation of Sleep method for Turtle
            Console.WriteLine("Turtle is sleeping in its shell.");
        }

        public override string Speak()
        {
            return "...";
        }

        public override string Move()
        {
            return "The Turtle is crawling around in the bushes.";
        }
    }

    public class Elephant : Animal
    {
        public Elephant(string name, int age) : base(name, age) { }

        public override void Eat()
        {
            // Implementation of Eat method for Elephant
            Console.WriteLine("Elephant is eating fruit.");
        }

        public override void Sleep()
        {
            // Implementation of Sleep method for Elephant
            Console.WriteLine("Elephant is sleeping against a tree.");
        }

        public override string Speak()
        {
            return "Trumpet!";
        }

        public override string Move()
        {
            return "The Elephant is walking toward the glass.";
        }
    }

    public class Crocodile : Animal
    {
        public Crocodile(string name, int age) : base(name, age) { }

        public override void Eat()
        {
            // Implementation of Eat method for Crocodile
            Console.WriteLine("Crocodile is eating meat.");
        }

        public override void Sleep()
        {
            // Implementation of Sleep method for Crocodile
            Console.WriteLine("Crocodile is sleeping in its cave.");
        }

        public override string Speak()
        {
            return "Snap!";
        }

        public override string Move()
        {
            return "The Crocodile is swimming in murky water.";
        }
    }

    public class Eagle : Animal
    {
        public Eagle(string name, int age) : base(name, age) { }

        public override void Eat()
        {
            // Implementation of Eat method for Eagle
            Console.WriteLine("Eagle is eating a small snake.");
        }

        public override void Sleep()
        {
            // Implementation of Sleep method for Eagle
            Console.WriteLine("Eagle is sleeping high up in a tree.");
        }

        public override string Speak()
        {
            return "Screech!";
        }

        public override string Move()
        {
            return "The Eagle is flying.";
        }
    }
}
