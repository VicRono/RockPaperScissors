using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock._1
{
    class ComputerPlayer : GamePlayer
    {
        Random random;

        public ComputerPlayer()
        {
            random = new Random();
        }

        public override void GetGesture()
        {
            int randomNumber = random.Next(0, gestureOptions.Count);
            playerGesture = gestureOptions[randomNumber];
        }
    }
}
