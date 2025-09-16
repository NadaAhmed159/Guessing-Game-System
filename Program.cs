namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessingGame guessingGame = new GuessingGame();
            guessingGame.play();
            Console.ReadKey();
        }
    }
}
