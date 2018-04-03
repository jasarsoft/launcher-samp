using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class PlayerClient
    {
        private string playerNick;
        private int playerScore;


        public PlayerClient(string nick, int score)
        {
            playerNick = nick;
            playerScore = score;
        }


        public string Nick
        {
            get { return playerNick; }
        }

        public int Score
        {
            get { return playerScore; }
        }
    }
}
