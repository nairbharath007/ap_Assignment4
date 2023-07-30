using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 10;
            int userGuess;
            int randomNumber;
            int numberOfAttempts;
            int userResponse;

            //Console.WriteLine("Welcome to Guess the Number Game");
            Console.WriteLine("░██╗░░░░░░░██╗███████╗██╗░░░░░░█████╗░░█████╗░███╗░░░███╗███████╗  ████████╗░█████╗░\r\n░██║░░██╗░░██║██╔════╝██║░░░░░██╔══██╗██╔══██╗████╗░████║██╔════╝  ╚══██╔══╝██╔══██╗\r\n░╚██╗████╗██╔╝█████╗░░██║░░░░░██║░░╚═╝██║░░██║██╔████╔██║█████╗░░  ░░░██║░░░██║░░██║\r\n░░████╔═████║░██╔══╝░░██║░░░░░██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░  ░░░██║░░░██║░░██║\r\n░░╚██╔╝░╚██╔╝░███████╗███████╗╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗  ░░░██║░░░╚█████╔╝\r\n░░░╚═╝░░░╚═╝░░╚══════╝╚══════╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝  ░░░╚═╝░░░░╚════╝░\r\n\r\n░██████╗░██╗░░░██╗███████╗░██████╗░██████╗  ████████╗██╗░░██╗███████╗\r\n██╔════╝░██║░░░██║██╔════╝██╔════╝██╔════╝  ╚══██╔══╝██║░░██║██╔════╝\r\n██║░░██╗░██║░░░██║█████╗░░╚█████╗░╚█████╗░  ░░░██║░░░███████║█████╗░░\r\n██║░░╚██╗██║░░░██║██╔══╝░░░╚═══██╗░╚═══██╗  ░░░██║░░░██╔══██║██╔══╝░░\r\n╚██████╔╝╚██████╔╝███████╗██████╔╝██████╔╝  ░░░██║░░░██║░░██║███████╗\r\n░╚═════╝░░╚═════╝░╚══════╝╚═════╝░╚═════╝░  ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝\r\n\r\n███╗░░██╗██╗░░░██╗███╗░░░███╗██████╗░███████╗██████╗░  ░██████╗░░█████╗░███╗░░░███╗███████╗██╗██╗\r\n████╗░██║██║░░░██║████╗░████║██╔══██╗██╔════╝██╔══██╗  ██╔════╝░██╔══██╗████╗░████║██╔════╝██║██║\r\n██╔██╗██║██║░░░██║██╔████╔██║██████╦╝█████╗░░██████╔╝  ██║░░██╗░███████║██╔████╔██║█████╗░░██║██║\r\n██║╚████║██║░░░██║██║╚██╔╝██║██╔══██╗██╔══╝░░██╔══██╗  ██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░╚═╝╚═╝\r\n██║░╚███║╚██████╔╝██║░╚═╝░██║██████╦╝███████╗██║░░██║  ╚██████╔╝██║░░██║██║░╚═╝░██║███████╗██╗██╗\r\n╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝  ░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝╚═╝\r\n");
            while (playAgain)
            {
                userGuess = 0;
                numberOfAttempts = 0;
                userResponse = 0;
                randomNumber = random.Next(min, max + 1);

                while (userGuess != randomNumber)
                {
                    Console.Write("Guess a number between " + min + " - " + max + " : ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guessed Number: " + userGuess);

                    if (userGuess > randomNumber)
                        Console.WriteLine(userGuess + " too high. ");
                    else if (userGuess < randomNumber)
                        Console.WriteLine(userGuess + " too low. ");
                    numberOfAttempts++;
                }
                Console.WriteLine("Number : " + randomNumber);
                Console.WriteLine("\t\t\t*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t\t\t*   CONGRATS!! YOU WON!!  *");
                Console.WriteLine("\t\t\t*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\nIt only took you " + numberOfAttempts + " attempts.");

                Console.WriteLine("\nPlay Again ?? Press 1 for Yes and 2 to exit the game. ");
                userResponse = Convert.ToInt32(Console.ReadLine());

                if (userResponse == 1)
                    playAgain = true;
                else if (userResponse == 2)
                    playAgain= false;
                    

            }
            Console.WriteLine("Thanks for Playing!!");
            Thread.Sleep(2500);
            Environment.Exit(0);
        }
    }
}
