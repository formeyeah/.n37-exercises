/*
Write a C# program that:
1. Defines a secret word (e.g., "CSharp").
2. Prompts the user to guess the word.
3. Uses a while loop to check the user's guess. If the guess is incorrect, the 
program should ask the user to try again.
4. Displays a message "Congratulations! You guessed the word correctly."
when the correct word is guessed.
5. Counts the number of attempts and displays the total attempts to the user at 
the end.
Note: Use conditional statements to check if the guess is correct or not.
*/



string SecretWord = "secret";

int counter = 0;


while (true)
{
    Console.WriteLine("Can you guess the secret word?\n try: ");
    string guess = Console.ReadLine();
    counter++;

    if (guess == SecretWord)
    {
        Console.WriteLine("Congratulations! You guessed the word correctly.");
        Console.WriteLine($"number of attempts {counter}");
        break;

    }
}



