
int sum =0;
int count = 0;
int number = 0;
while (number != -1)
{
    Console.Write("Give Me your number please (-1 for exit): ");
    string input = Console.ReadLine();
    number = int.Parse(input);
    if (number != -1)
    {
        sum += number;
        count++;
    }
}
Console.WriteLine($"Your Avg is : {sum/count}");