public class Car
{
    string CarName = "Mashine Amoo";
    public static int TotalCars = 0;
    public Car()
    {
        TotalCars++;
        Console.WriteLine(" We have new Car");
    }

    public string Start()
    {
        string MotorName = "Benz";
        Console.WriteLine("I Start " + MotorName);
        return MotorName;
    }
    public string Stop()
    {
        string TrunOffTime = "1403-1010:20:20";
        Console.WriteLine(TrunOffTime);
        return TrunOffTime;
    }

    public void SetName(string newName)
    {
        CarName = newName;
    }
    public void DisplayCarName()
    {
        Console.WriteLine($"Current Car Name: {CarName}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Create First Car ===");
        Car car1 = new Car();
        car1.Start();
        car1.Stop();
        car1.SetName("Car #1 ");
        car1.DisplayCarName();
        Console.WriteLine("\n===  Create Second Car ===");
        Car car2 = new Car();
        car2.Start();
        car2.Stop();
        car2.SetName("Car #2");
        car2.DisplayCarName();

        Console.WriteLine(" first car name is :");
        car1.DisplayCarName();

        Console.WriteLine(" Second car name is :");
        car2.DisplayCarName();

        Console.WriteLine("\n=== show Static Variable Value ===");
        Console.WriteLine($"Total Cars (via class): {Car.TotalCars}");
    }
}