namespace _02_High_Low_Number_Guessing;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        const int MIN_RANDOM_NUMBER = 1;
        const int MAX_RANDOM_NUMBER = 100;
        int randomNumber = rnd.Next(MIN_RANDOM_NUMBER, MAX_RANDOM_NUMBER);
        Console.WriteLine($"Random number: {randomNumber}");
        
        Console.WriteLine("Hi, let's play a game! Can you guess the number between 1 and 100?");
        int guessedNumber = int.Parse(Console.ReadLine());
        int tries = 0;

        while (guessedNumber != randomNumber)
        {
            if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Too low, try again!");
            }
            if(guessedNumber > randomNumber)
            {
                Console.WriteLine("Too high, try again!");
            }

            const int MAX_TRIES = 10;
            if (tries > MAX_TRIES)
            {
                Console.WriteLine("Sorry, you had too many tries");
                return;
            }

            const int DISTANCE_TO_GUESSED_NUMBER = 5;
            if ((Math.Abs(randomNumber - guessedNumber)) <= DISTANCE_TO_GUESSED_NUMBER)
            {
                Console.WriteLine("But you're close!");
            }
            guessedNumber = int.Parse(Console.ReadLine());
            tries++;
        }
        
        Console.WriteLine("Correct! The random number is: " + randomNumber);
    }
}