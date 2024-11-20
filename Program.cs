using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Guessing_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Predefined lucky number
            int luckyNumber = 3;

            // Ask user if they want to play
            Console.WriteLine("Do you want to play the Color Guessing Challenge? (YES/NO)");
            string playResponse = Console.ReadLine().ToUpper();

            // Check user's response
            if (playResponse == "NO")
            {
                Console.WriteLine("Maybe another time.");
            }
            else if (playResponse == "YES")
            {
                // Prompt for favorite color
                Console.WriteLine("Enter your favorite color:");
                string favoriteColor = Console.ReadLine().ToLower();

                // Check if the entered color is recognized
                if (favoriteColor == "red" || favoriteColor == "blue" || favoriteColor == "green")
                {
                    // Prompt for number guessing
                    Console.WriteLine("Guess a number between 1 and 5:");
                    int guessedNumber = Convert.ToInt32(Console.ReadLine());

                    // Read and validate the guessed number
                    if (guessedNumber <= 5)
                    {
                        // Check if guessed number matches the lucky number
                        if (guessedNumber == luckyNumber)
                        {
                            Console.WriteLine("You guessed it! You’re a color genius!");
                        }
                        else
                        {
                            Console.WriteLine("Good try, but that’s not the lucky number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 5.");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a color I recognize.");
                }
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter YES or NO.");
            }
        }

            }


        }
