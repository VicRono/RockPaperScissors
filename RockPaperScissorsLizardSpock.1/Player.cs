using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock._1
{
    class GamePlayer
    {
        public string playerGesture;
        public int playerScore = 0;
        public List<string> gestureOptions;

        public GamePlayer()
        {
            gestureOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        public virtual void GetGesture()
        {
            Console.WriteLine("Please select one of the following: 'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock'");
            playerGesture = Console.ReadLine();
        }        

              
    }
}
