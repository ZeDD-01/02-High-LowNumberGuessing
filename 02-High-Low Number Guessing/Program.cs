namespace _02_High_Low_Number_Guessing;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 100);

        int[] searchArray = new int[101];

        for (int i = 0; i <= 100; i++)
        {
            searchArray[i] = i;
            
        }
        
        Console.WriteLine("Hi, let's play a game! Can you guess the number between 1 and 100?");
        int guessedNumber = int.Parse(Console.ReadLine());
        
        
        
        Console.WriteLine("The random number is: " + randomNumber);
        Console.WriteLine(guessedNumber);
    }
}