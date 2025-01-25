
string input = "";
int sum = 0;
int count = 0;
do
{
    Console.Write("give me a number: ");
    input = Console.ReadLine();
    sum += int.Parse(input);
    if (input != "0")
    {
        count++;
    }
} while (input != "0");

Console.WriteLine($"Avg of your numbers = {sum / count}");
Console.ReadKey();