using System.Drawing;

class Program
{

    class Person
    {
        public string Name;
        public int Age;
        string Fathername;
        bool IsReadyForWedding;
        // Access Modifiers     childs    other classes     other assembly
        //private                 no          no                  no   
        //protected               yes         no                  no
        //internal                yes         yes                 no

        //Modifiers        Static          abstract      Sealed

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    class Student : Person
    {


    }

    class Animal
    {
        private string secretname;
        public string name
        {
            get { return $"Dear {secretname}"; }
            set { secretname = value; }
        }
        public int age;
        public void Eat()
        {
            Console.WriteLine($" {name} is eating .");
        }
    }



    class Dog : Animal
    {
        public void HopHop()
        {
            age++;
            Console.WriteLine($" {name} says Hop Hop ! .");
        }
    }

    class Dock : Animal
    {
        public static string Color = "Green";
        public static void SayQuack()
        {
            Console.WriteLine("Quack Quack");
        }
        public void Fly()
        {
            Console.WriteLine($" {name} is Flying :)) .");
        }
    }


    abstract class Shape
    {
        public abstract double GetArea();

    }

    class Circle : Shape
    {
        public double radius;
        public sealed override double GetArea() => radius * radius * Math.PI;
        //public override double GetArea()
        //{
        //    return radius * radius * Math.PI;
        //}
    }

    class MiniCirlce : Circle
    {
        //public override double GetArea() => 10;  // whe can note override because it's Sealed on Parent
    }

    class Rectangle : Shape
    {
        public double width;
        public double height;
        public override double GetArea() => width * height;
    }

    public class Car
    {
        public string Model { get; }
        public string Color { get; }
        public int Year { get; }
        public string EngineType { get; }
        public bool IsElectric { get; }
        private bool IsOn { get; set; }

        public void TurnOn() {
            IsOn = true;
        }
        public void TurnOff()
        {
            IsOn = false;
        }

        public string IsTurnedOn() { 
        
            return IsOn?"this car is turned On!" : "this car is turned Off!";
        }
        
        public Car(string model, string color, int year, string engineType, bool isElectric)
        {
            Model = model;
            Color = color;
            Year = year;
            EngineType = engineType;
            IsElectric = isElectric;
            TurnOn();
        }
    }

    public static void ModifyValue(ref int number)
    {
        number += 10;
    }

    public static void GetValues(out int number, out string text)
    {
        number = 42;
        text = "Hello, C#";
    }

    public static void PrintValue(in int number)
    {
        Console.WriteLine(number); 
    }


    static void Main()
    {

        int value = 5;
        ModifyValue(ref value);
        Console.WriteLine(value);
        
        
        int num;
        string str;
        GetValues(out num, out str);
        Console.WriteLine($"{num}, {str}");

        value = 20;
        PrintValue(in value);


        //var car = new Car("Tesla", "Red", 2023, "Electric", true);
        //Console.WriteLine(car.IsTurnedOn());
        //car.TurnOff();
        //Console.WriteLine(car.IsTurnedOn());


        //Dock.SayQuack();
        //Dock donald = new Dock();
        //donald.Fly();
        //Dog dg = new Dog();
        //dg.age++;
        //dg.name = "test";
        //dg.Eat();
        //dg.HopHop();

        //Dock dock = new Dock();
        //dock.name = "docky";
        //dock.Eat();
        //dock.Eat();
        //dock.Fly();
        //Person person = new Person();
        //person.Name = "Ali";
        //person.Age = 25;
        //person.Introduce();

        //MiniCirlce miniCirlce = new MiniCirlce();
        //miniCirlce.radius = 10;
        //miniCirlce.GetArea();
        //Console.WriteLine($"your circle area = {miniCirlce.GetArea()}");

        //Circle circle = new Circle();
        //circle.radius = 10;
        //Console.WriteLine($"your circle area = {circle.GetArea()}");
        //Console.WriteLine("---------------------------------------");
        //Rectangle rectangle = new Rectangle();
        //rectangle.width = 10;
        //rectangle.height = 10;
        //Console.WriteLine($"your rectangle Area = {rectangle.GetArea()}");
    }
}