
namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class PlayerInfo
    {
        private int playerID;
        private string playerNick;
        private int playerScore;
        private int playerPing;

        
        public PlayerInfo(int id, string nick, int score)
        {
            this.playerID = id;
            this.playerNick = nick;
            this.playerScore = score;
            this.playerPing = 0;
        }

        public PlayerInfo(int id, string nick, int score, int ping)
        {
            this.playerID = id;
            this.playerNick = nick;
            this.playerScore = score;
            this.playerPing = ping;
        }


        public int ID
        {
            get { return playerID; }
        }

        public string Nick
        {
            get { return playerNick; }
        }

        public int Score
        {
            get { return playerScore; }
        }

        public int Ping
        {
            get { return playerPing; }
        }
    }
}
