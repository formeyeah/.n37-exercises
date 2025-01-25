Console.WriteLine("Give me Your Exam Result's Number(0-20): ");
string strnumber = Console.ReadLine();
double number = double.Parse(strnumber);


switch (number)
{
    case 10:
        Console.WriteLine("Napelopni!");
        break;
    case 20:
        Console.WriteLine("Afarin!");
        break;
    default:

        if (number > 20)
        {
            Console.WriteLine("Your Number is out of Normal Range!");
        }
        else if (number < 10)
        {
            Console.WriteLine("Mardood!");
        }
        else if (number < 16)
        {
            Console.WriteLine("Ghabool!");
        }
        else if (number < 18)
        {
            Console.WriteLine("khoob!");
        }
        else if (number == 18 || number ==19)
        {
            Console.WriteLine("Shagerd dowom shodi! ");
        }
        else
        {
            Console.WriteLine("Awli!");
        }
        break;
}