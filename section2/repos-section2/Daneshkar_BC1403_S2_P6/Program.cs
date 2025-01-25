

int sum = 0;
int count = 0;
for (int i = 1; i <= 10; i++) 
{
    Console.Write($"Give me your Lessens #{i}'s Number ( -1 for exit): ");
    string input = Console.ReadLine();
    int number = int.Parse( input );
    if (number == -1) { 
    break;
    }
    sum += number;
    count++;
}

Console.WriteLine($"Your Avg is : {sum / count}");

