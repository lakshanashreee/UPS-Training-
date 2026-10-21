using System;

class Animal
{
    public void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public new void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Animal();
        a.Sound();

        Dog d = new Dog();
        d.Sound();

        Animal a2 = new Dog();
        a2.Sound();
    }
}