namespace _02_High_Low_Number_Guessing;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 100);
        
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

            if (tries > 10)
            {
                Console.WriteLine("Sorry, you had too many tries");
                return;
            }

            if (guessedNumber + 5 == randomNumber || guessedNumber - 5 == randomNumber)
            {
                Console.WriteLine("You're close!");
            }
            guessedNumber = int.Parse(Console.ReadLine());
            tries++;
        }
        
        Console.WriteLine("Correct! The random number is: " + randomNumber);
    }
}