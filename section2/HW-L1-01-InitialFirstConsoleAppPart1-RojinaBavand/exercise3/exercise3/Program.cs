Random rnd = new Random();
int guess=rnd.Next(1,10);
//int guess = 1;
string StringGuessedNumber = "";
int guessedNumber = 0;


    while (guessedNumber != guess)
    {
    for (int i = 0; i < 5; i++) {

        Console.WriteLine("guess a number from 1 to 10:");
        StringGuessedNumber = Console.ReadLine();
        guessedNumber = int.Parse(StringGuessedNumber);
        if (guessedNumber == guess)
        {
            Console.WriteLine("Congratulations! Your Guess was correct!!!!");
            break;
        }
    }
    if (guessedNumber != guess) { 
    Console.WriteLine($"You Failed. number was {guess}");
    break;
    }


}
