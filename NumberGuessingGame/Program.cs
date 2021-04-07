using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"args[{i}]={args[i]}");
            }
            foreach (var arg in args)
            {
                Console.WriteLine($"");
            }*/

            if (args.Length != 1)
            {
                throw new Exception("Please only input one number");
            }

            int usrGuess;
            if (Int32.TryParse(args[0], out usrGuess))
            {
                var hail = new Hailstone(usrGuess);
            }
            else
                throw new Exception("Please input a number, not whatever you just gave me");

        }
    }
}
