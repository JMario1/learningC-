using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 0;
            Random rng = new Random();
            int guess = 0;
            Console.WriteLine("Welcome, want to play a game!!!");
            Console.WriteLine("Start by picking a mode. \n Easy: guess a number between 1 and 10, you got 6 tries. Press 1 to select  \n Intermediate: guess a number between 1 and 20, you got 4 tries. Press 2 to select \n Hard: guess a number between 1 and 50, you got 3 tries. Press 3 to select. \n");
            Console.Write("Choose mode: ");
            level = int.Parse(Console.ReadLine());
            if(level == 1)
            {
                int number = rng.Next(1, 10);
                for(int i =1; i <= 6; i++)
                {
                    Console.Write("Enter your guess: ");
                    guess = int.Parse(Console.ReadLine());
                    if(guess == number)
                    {
                        Console.WriteLine("Congratulation!!! \n You won");
                        break;
                    }
                    else if( i == 6)
                    {
                        Console.WriteLine("You lost, better luck next time");
                        Console.WriteLine("Correct answer was " + number );
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }
                }
                
            }
            else if(level == 2)
            {
                int number = rng.Next(1, 10);
                for(int i =1; i <= 4; i++)
                {
                    Console.Write("Enter your guess: ");
                    guess = int.Parse(Console.ReadLine());
                    if(guess == number)
                    {
                        Console.WriteLine("Congratulation!!! \n You won");
                        break;
                    }
                    else if( i == 4)
                    {
                        Console.WriteLine("You lost, better luck next time");
                        Console.WriteLine("Correct answer was "+ number );
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }
                }
            }
            else if(level == 3)
            {
                int number = rng.Next(1, 10);
                for(int i =1; i <= 3; i++)
                {
                    Console.Write("Enter your guess: ");
                    guess = int.Parse(Console.ReadLine());
                    if(guess == number)
                    {
                        Console.WriteLine("Congratulation!!! \n You won");
                        break;
                    }
                    else if( i == 3)
                    {
                        Console.WriteLine("You lost, better luck next time");
                        Console.WriteLine("Correct answer was "+ number );
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }
                }
            }
            

        }
    }
}
