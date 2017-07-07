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
            Console.WriteLine("Let's play a game! Guess your lucky numbers.\nFirst enter a number.");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter a bigger number.");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Please enter a valid number, larger then the first.");
            }
            else
            {
                Random luckyNumber = new Random();

                int[] luckyArray = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    luckyArray[i] = luckyNumber.Next(firstNumber, secondNumber);
                }
                int[] guessesArray = new int[6];
                Console.WriteLine("We have six lucky number for you.\n" +
                    "For every number you get right you will recieve\n10 points for a jack pot of 60 points.\n"
                    + "What is you first guess?");
                for (int i = 0; i < guessesArray.Length; i++)
                {
                    Console.WriteLine(guessesArray[i]);
                    for (int j = 0; j < guessesArray.Length; j++)
                    {
                        guessesArray[j] = int.Parse(Console.ReadLine());
                    }
                }
                
                
                
                
                
            }  
        }
    }
}
