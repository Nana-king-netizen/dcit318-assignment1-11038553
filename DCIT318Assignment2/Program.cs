using System;

namespace DCIT318Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();
            
            myAnimal.MakeSound(); 
            myDog.MakeSound();
            myCat.MakeSound();
           
            Console.WriteLine();

            Circle circle = new Circle(5.0);
            Console.WriteLine($"Circle Area: {circle.GetArea()}");

            Rectangle rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

            Console.WriteLine();

            Car myCar = new Car();
            Bicycle myBicycle = new Bicycle();

            myCar.Move();
            myBicycle.Move();


        }
    }
}
