
public struct Rectangle
{
    public int width;
    public int Height;

    public Rectangle(int w, int h)
    {
        width = w;
        Height = h;
    }

    public void DisplayArea()
    {
        string prompt = $"Your Rectangle's Area = : {width * Height}";
        Console.WriteLine(prompt);
    }
}



class Program
{
    static void Main(string[] args)
    {
        //Rectangle FirstRectangle = new Rectangle(10, 5);
        //FirstRectangle.DisplayArea();

        //Rectangle SeconfRecttangle = FirstRectangle;

        //SeconfRecttangle.width = 20;
        //FirstRectangle.DisplayArea();
        //SeconfRecttangle.DisplayArea();
        //int[] numbers = {1,2,3,4,5,6,7};
        //List<int> numbers2 = new List<int>();
        //numbers2.Add(1);
        //numbers2.Add(2);
        //numbers2.Add(3);
        //numbers2.Add(4);
        //numbers2.Add(5);
        //numbers2.Add(6);
        //numbers2.Add(7);

        Dictionary<int,string> students = new Dictionary<int,string>();
        students.Add(1, "Hasan");
        students.Add(2, "ahmad");
        students.Add(3, "ali");
        students.Add(4, "milad");
        students.Add(5, "babak");
        students.Add(6, "parsa");
        students.Add(7, "saeed");
        students.Add(8, "massoud");
        students.Remove(4);
        Console.WriteLine(students[5]);

    }
}