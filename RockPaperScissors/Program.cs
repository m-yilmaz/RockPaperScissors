using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int computerScore = 0, playerScore = 0;
            string computerMove = "";
            string[] rps = { "r", "p", "s" };
            Random rnd = new Random();

        getInput:
            Console.Clear();
            Console.WriteLine("******* Rock | Paper | Scissors  ********");
            Console.WriteLine("        Rock     =>   R");
            Console.WriteLine("        Paper    =>   P");
            Console.WriteLine("        Scissors =>   S");
            Console.WriteLine("*****************************************");
            Console.Write("Enter your selection: ");
            string playerMove = Console.ReadLine().ToLower();
            computerMove = rps[rnd.Next(3)];


            if ((computerMove == "r" && playerMove == "s") || (computerMove == "p" && playerMove == "r") || (computerMove == "s" && playerMove == "p"))
            {
                computerScore += 10;
                Console.WriteLine($"Computer : {computerMove}  -----   {playerMove} : You ");
                Console.WriteLine("Computer Wins !!");
                Console.WriteLine($"{computerScore} -- {playerScore}");
            }
            else if ((playerMove == "r" && computerMove == "s") || (playerMove == "p" && computerMove == "r") || (playerMove == "s" && computerMove == "p"))
            {
                playerScore += 10;
                Console.WriteLine($"Computer : {computerMove}  -----   {playerMove} : You ");
                Console.WriteLine("You Wins !!");
                Console.WriteLine($"{computerScore} -- {playerScore}");
            }
            else
            {
                Console.WriteLine("Draw");
                Console.WriteLine($"{computerScore} -- {playerScore}");
            }

            Console.Write("Do you want continue ? (Y/N): ");
            String cevap = Console.ReadLine().ToLower();
            if (cevap != "n")
                goto getInput;

            Console.WriteLine($"Computer Score: {computerScore} --- {playerScore} : Player Score");
            if (computerScore > playerScore)
                Console.WriteLine("The Computer Won the Game");
            else if (computerScore < playerScore)
                Console.WriteLine("You Won The Game");
            else
                Console.WriteLine("Game Draw");
            Console.ReadKey();

        }
    }
}
