using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain;
            do
            {// lucky numbers are always 0-5, the indext is being used instead of the lucky numbers being generated randomly. 
                //Asking for user input for range.
                Console.WriteLine("Welcome to the Blips and Chits aniversery number game!\n" 
                    + "Guess your lucky numbers.\nFirst enter a number.");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Now enter a bigger number.");
                int secondNumber = int.Parse(Console.ReadLine());

                //Ensuring vaild range.
                while (firstNumber >= secondNumber)
                {
                    Console.WriteLine("Please enter a valid number, larger then the first.");
                    secondNumber = int.Parse(Console.ReadLine());
                }

                //Creating random numbers within range and storing in luckyArray[].
                Random luckyNumber = new Random();
                int lucky = luckyNumber.Next(firstNumber, secondNumber); 
                int[] luckyArray = new int[6];
                for (int i = 0; i < 6 ; i++)
                {
                    luckyArray[i] = luckyNumber.Next(firstNumber, secondNumber);
                }
                //Asking for guesses.
                int[] guessesArray = new int[6];
                Console.WriteLine("We have six lucky numbers for you.\n" +
                    "For every number you get right you will recieve\n10 shmeckels for a jack pot of 60 shmeckels.\n"
                    + "Guess six numers between " + firstNumber + " and " + secondNumber + "."
                    + "Press enter after each guess.\n" + "*Shmeckels only valid on federation sanctioned planets.*");

                //Catching user input and storing in guessesArray[].
                for (int j = 0; j < guessesArray.Length; j++)
                {
                    guessesArray[j] = int.Parse(Console.ReadLine());
                    while (guessesArray[j] < firstNumber || guessesArray[j] > secondNumber)
                    {
                        Console.WriteLine("Please enter a valid number.");
                        guessesArray[j] = int.Parse(Console.ReadLine());
                    }
                }

                //Scoreing calculation.
                int correct = 0;
                for (int k = 0; k < luckyArray.Length; k++)
                {
                    Console.WriteLine("Lucky number: " + k);

                    foreach (int number in luckyArray)
                    {

                        if (number == guessesArray[k])
                        {
                            correct += 1;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                int winings = correct * 10;
                Console.WriteLine("you got: " + correct + " right!\n"
                    + "You won: " + winings + " shmeckels!");

                Console.WriteLine("Do you want to play again? YES/NO");
                playAgain = Console.ReadLine();
            }
            //Play again option.
            while (playAgain.ToUpper() == "YES");


        }
    }
}
