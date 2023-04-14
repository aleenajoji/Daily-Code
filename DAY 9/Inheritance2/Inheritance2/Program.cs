using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{


    // single inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    // multi-level inheritance
    class Mammal : Animal
    {
        public void Run()
        {
            Console.WriteLine("Mammal is running.");
        }
    }

    class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Horse is galloping.");
        }
    }

    // hierarchical inheritance
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }

    }

    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting.");
        }
    }

    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }

    
    // main program
    class Program
    {
        static void Main(string[] args)
        {
            // single inheritance
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            // multi-level inheritance
            Horse horse = new Horse();
            horse.Eat();
            horse.Run();
            horse.Gallop();

            // hierarchical inheritance
            Eagle eagle = new Eagle();
            Penguin penguin = new Penguin();
            eagle.Fly();
            eagle.Hunt();
            penguin.Fly();
            penguin.Swim();

            

            Console.ReadLine();
        }
    }

}
