using System;

namespace Mastermind
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int first = random.Next(1, 6);
            int second = random.Next(1, 6);
            int third = random.Next(1, 6);
            int fourth = random.Next(1, 6);

            string numAsString = Convert.ToString(first) + second + third + fourth;
            char[] numAsArray = numAsString.ToCharArray();
            
            for (int turn = 0; turn < 10; turn++)
            {
                string plus = "";
                string minus = "";
                Console.Clear();
                Console.WriteLine($"You have {10 - turn} turns left!");
                Console.WriteLine("Please enter a 4 digit number to guess");
                string guess = Console.ReadLine();
                char[] guessAsArray = guess.ToCharArray();
                if (guess == numAsString)
                {
                    Console.WriteLine("YOU WIN!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {

                        if (numAsArray[i] == guessAsArray[i])
                        {
                            plus += "+";
                        }
                        else if (numAsArray[i] != guessAsArray[i] && guess.Contains(numAsArray[i]))
                        {
                            minus += "-";
                        }
                    }
                }
                Console.WriteLine($"Correct digit, correct position: {plus}");
                Console.WriteLine($"Correct digit, wrong postion: {minus}");
                Console.WriteLine("Press enter to try again!");
                Console.ReadLine();
            }
            Console.WriteLine("GAME OVER!");
            Console.ReadLine();
        }
    }
}
