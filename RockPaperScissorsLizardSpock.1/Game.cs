using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock._1
{
    class Game
    {
        // member variables (HAS A)
        GamePlayer playerOne;
        GamePlayer playerTwo;               

        // constructor
        public Game()
        {
            playerOne = new HumanPlayer();
        }

        // member methods (CAN DO)
        public void RunGame()
        {
            DeterminePlayerTwo();
            playerOne.GetGesture();
            playerTwo.GetGesture();
            CompareGestures();
        }

        public void DeterminePlayerTwo()
        {
            Console.WriteLine("Would you like to play Human VS Human? 'Y' for yes or 'N' for no");
            char UserInput = char.Parse(Console.ReadLine());

            if (UserInput == 'Y')
            {
                playerTwo = new HumanPlayer();
            }
            else if(UserInput == 'N')
            {
                playerTwo = new ComputerPlayer();
            }
            else
            {
                Console.WriteLine("Whoops! Please follow the instructions...");
                DeterminePlayerTwo();
            }
        }

        public void CompareGestures()
        {
            switch (playerTwo.playerGesture)
            {
                case "Rock":
                    Console.WriteLine("Player 2 chose Rock");
                    if (playerOne.playerGesture == "Rock")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (playerOne.playerGesture == "Paper")
                    {
                        Console.WriteLine("Player 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Scissors")
                    {
                        Console.WriteLine("Player 2 Wins!!\n\n");
                        playerTwo.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Lizard")
                    {
                        Console.WriteLine("Player 2 Wins!!\n\n");
                        playerTwo.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Spock")
                    {
                        Console.WriteLine("PLAYER 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    break;
                case "Paper":
                    Console.WriteLine("Player 2 chose Paper");
                    if (playerOne.playerGesture == "Rock")
                    {
                        Console.WriteLine("Player 2 Wins!!\n\n");
                        playerTwo.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Paper")
                    {
                        Console.WriteLine("Draw!!\n\n");
                    }
                    else if (playerOne.playerGesture == "Scissors")
                    {
                        Console.WriteLine("Player 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Lizard")
                    {
                        Console.WriteLine("Player 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Spock")
                    {
                        Console.WriteLine("Player 2 Wins!!\n\n");
                        playerTwo.playerScore++;
                    }
                    break;
                case "Scissors":
                    Console.WriteLine("Player 2 chose Scissors");
                    if (playerOne.playerGesture == "Rock")
                    {
                        Console.WriteLine("Player 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Paper")
                    {
                        Console.WriteLine("Player 2 Wins!!\n\n");
                        playerTwo.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Scissors")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (playerOne.playerGesture == "Lizard")
                    {
                        Console.WriteLine("Player 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Spock")
                    {
                        Console.WriteLine("Player 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    break;
                case "Lizard":
                    Console.WriteLine("Player 2 chose Lizard");
                    if (playerOne.playerGesture == "Rock")
                    {
                        Console.WriteLine("Player 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Paper")
                    {
                        Console.WriteLine("Player 2 Wins!!\n\n");
                        playerTwo.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Scissors")
                    {
                        Console.WriteLine("Player 1 WINS!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Lizard")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (playerOne.playerGesture == "Spock")
                    {
                        Console.WriteLine("Player 2 WINS!!\n\n");
                        playerTwo.playerScore++;
                    }
                    break;
                case "Spock":
                    Console.WriteLine("Player 2 chose Spock");
                    if (playerOne.playerGesture == "Rock")
                    {
                        Console.WriteLine("Player 2 Wins!!\n\n");
                        playerTwo.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Paper")
                    {
                        Console.WriteLine("Player 1 Wins!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Scissors")
                    {
                        Console.WriteLine("Player 2 WINS!!\n\n");
                        playerTwo.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Lizard")
                    {
                        Console.WriteLine("Player 1 WINS!!\n\n");
                        playerOne.playerScore++;
                    }
                    else if (playerOne.playerGesture == "Spock")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    break;
            }

        }
     }
}


