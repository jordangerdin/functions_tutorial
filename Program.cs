// Quick reference program on functions, rewriting a guessing game.

using System;

namespace functions_tutorial
{
    class Program
    {


        static void Main(string[] args){

            
            Console.WriteLine("Player 1 enter a number");
            
            // Call StartGame function to get initial number
            int guessNum = StartGame();

            // Pass initial number into GuessGame function, which will return a boolean
            bool guessed1 = GuessGame(guessNum);

            // End condition
            if (guessed1 == true){
                Console.WriteLine("You beat player 1");
            } else {
                Console.WriteLine("Player 1 beat you");
            }
            
        }

        // Game creation function
        static int StartGame(){
            int numToGuess = ValidateInt(GetUseInp());
            while(numToGuess == -1){
                numToGuess = ValidateInt(GetUseInp());
            }

            return numToGuess;
        }

        // Give second player a few guesses, letting p2 know if the number is higher or lower
        static bool GuessGame(int numberGuess){
            Console.WriteLine("Good luck Player 2");
            
            for(int i = 5; i > 0;){
                int p3input = ValidateInt(GetUseInp()));
                if (p3input == numberGuess){
                    Console.WriteLine("Nice job");
                    return true;
                } else if (p3input > numberGuess){
                    Console.WriteLine("Incorrect, the number is lower than " + p3input);
                } else if (p3input < numberGuess){
                    Console.WriteLine("Incorrect, the number is greater than " + p3input);
                }

                i = i-1;

                Console.WriteLine("You have " + i + " guesses remaining.");
            }

            return false;
            
        }


        // Function to validate for integers
        static int ValidateInt(string x){
            int y;
            if (Int32.TryParse(x, out y)){
                return y;
            }
            else{
                Console.WriteLine("Not a valid integer.");
                return -1;
            }
        }

        // Function to get user input, replaces multiple uses of Console.ReadLine() in code
        static string GetUseInp(){
            string text = Console.ReadLine();
            return text;
        }
    }
}
