namespace GuessingGame
{
    internal class GuessingGame
    {
        public void play()
        {
            string name = start();
            bool again=true;
            while (again)
            {
                int level = setDifficulty();
                int start = 0, end = 0;
                int randomNumber = GenerateNumber(level, ref start, ref end);
                int tries = Notries(),tryloop=0;
                bool ans = true;
                do
                {
                    tryloop++;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (!ans)
                    Console.WriteLine($"Your remaining tries :{tries}");

                    tries--;
                    ans = playing(ref start, ref end, randomNumber);
                    
                } while (tries > 0 && !ans);
                showScoor(ans,tryloop, randomNumber);

                again = !endGame();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Good Bye {name}!");
            Console.ResetColor();
        }
        private string start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------Hello To Our Guessing Game System-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string name =Console.ReadLine();
            return name;
        }
        private int Notries()
        {
            while (true)
            {
                try {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("enter number of tries you want: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int tries = int.Parse(Console.ReadLine());
                    if (tries <= 0) throw new Exception();
                   return tries; 
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("enter valied integer tries greater than zero");
                }
            }

            
        }
        private int setDifficulty()
        {
            while (true) {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1) Easy\n2) Medium\n3) Hard ");
                    Console.Write("choose the number that reprsent difficulty level :");
                    Console.ForegroundColor = ConsoleColor.Cyan; 
                    int level = int.Parse(Console.ReadLine());
                    if (!(level ==1|| level == 2 || level == 3)) throw new Exception();

                    return level;

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("enter valid level number from below");
                }

            }

        }
        private int GenerateNumber(int Level, ref int start, ref int end)
        {
            Random rand = new Random();
            int randomNumber = 0;
            switch (Level)
            {
                case 1:
                    randomNumber = rand.Next(1, 11);
                    start = 1; end = 10;
                    break;
                case 2:
                    randomNumber = rand.Next(11, 101);
                    start = 11; end = 100;
                    break;
                case 3:
                    randomNumber = rand.Next(101, 1001);
                    start = 101; end = 1000;
                    break;
            }
            return randomNumber;
        }
        private bool playing( ref int  start, ref int  end, int randomNumber)
        {
            int guess = 0;
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"choose number from {start} to {end}");
                    Console.ForegroundColor = ConsoleColor.Cyan; 
                    guess = int.Parse(Console.ReadLine());
                    if (!(guess >= start && guess <= end)) throw new Exception();

                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"enter valid integer between {start} and {end}");
                }
            }

            if (guess < randomNumber)
            {
                start = guess + 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("number is smaller");
                return false;
            }
            else if (guess > randomNumber)
            { end=guess - 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("number is greater");
                return false;
            }
            else { return true; }

        }
        private void showScoor(bool ans, int tries, int randomNumber)
        {
            if (ans) {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"congrates You get it in :{tries} tries !"); }
            else {
                Console.WriteLine($"The number is:{randomNumber}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over you finished your tries"); }
            
        }
        private bool endGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Do you want to play again ?(Y/N) :");
            while (true)
            {
                try {
                    Console.ForegroundColor = ConsoleColor.Cyan; 
                    string playAgain = Console.ReadLine();
                    if(playAgain == "Y" || playAgain == "y")
                        return false;
                    else if (playAgain == "N" || playAgain == "n")
                        return true;
                    else throw new Exception();
                }
                catch {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("enter valied choise (Y/N)"); }
            }

        }
    }
}
