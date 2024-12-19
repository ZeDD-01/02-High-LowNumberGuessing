namespace _02_High_Low_Number_Guessing;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int minRandomNumber = 1;
        int maxRandomNumber = 100;
        int randomNumber = rnd.Next(minRandomNumber, maxRandomNumber);
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

            int maxTries = 10;
            if (tries > maxTries)
            {
                Console.WriteLine("Sorry, you had too many tries");
                return;
            }

            if ((Math.Abs(randomNumber - guessedNumber)) <= 5)
            {
                Console.WriteLine("But you're close!");
            }
            guessedNumber = int.Parse(Console.ReadLine());
            tries++;
        }
        
        Console.WriteLine("Correct! The random number is: " + randomNumber);
    }
}