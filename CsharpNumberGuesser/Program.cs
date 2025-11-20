// See https://aka.ms/new-console-template for more information

bool isCorrectGuess = false;
Random random = new Random();

int randomNum = random.Next(0, 11);

Console.WriteLine("Welcome to the number guessing game!");
Console.WriteLine("A number between 1 and 10 will be generated");
Console.WriteLine("If you guess the correct number, you win!");

Console.WriteLine(randomNum);

while (!isCorrectGuess)
{
    Console.WriteLine("Please enter your guess.");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > randomNum)
    {
        Console.WriteLine("Your guess is too high");
    }
    else if (guess < randomNum)
    {
        Console.WriteLine("Your guess is too low");
    }
    else
    {
        Console.WriteLine("Correct!");
    }
}

Console.ReadKey();