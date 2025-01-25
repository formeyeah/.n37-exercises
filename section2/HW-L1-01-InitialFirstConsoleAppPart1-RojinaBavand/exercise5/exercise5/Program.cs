/*
 Exercise 2: Sum of Odd Numbers 
Problem:
Write a C# program that:
1. Prompts the user to enter a positive integer n.
2. Uses a for loop to find and calculate the sum of all odd numbers between 1 
and n.
3. Displays the total sum of odd numbers in the console.
Notes:
 If the user enters a number less than 1, the program should display a 
message indicating the input is invalid and prompt the user again.
 To check if a number is odd, use the % operator
 */

Console.WriteLine("enter a positive number: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int sum = 0;
while (true)
{
    if (number < 1)
    {
        Console.WriteLine("input is invalid");
        Console.WriteLine("enter a positive number: ");
        input = Console.ReadLine();
        number = int.Parse(input);
    }
    else if (number >= 1)
    {
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 1)
            {
                sum += i;
            }
        }
        Console.WriteLine($"sum of odd numbers to {number} is {sum}");
        break;
    }
}
    








