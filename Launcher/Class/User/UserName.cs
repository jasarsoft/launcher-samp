using System;
using System.Text.RegularExpressions;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class UserName
    {
        private string playerName;
        private bool playerRolePlay;
        private readonly string nameDefault;

        private int lengthMin;      //minimalno dozvoljena duzina imena
        private int lengthMax;      //maksimalno dozvoljena duzina imena

        
        
        private UserName()
        {
            nameDefault = "Ime_Prezime";
            lengthMin = 3;
            lengthMax = 24;
        }

        public UserName(string name) : this()
        {
            playerName = name;
        }

        public UserName(string name, int min, int max) : this(name)
        {
            lengthMin = min;
            lengthMax = max;
        }


        public string Name
        {
            get { return playerName; }
        }

        public int LengthMin
        {
            get { return lengthMin; }
            set { lengthMin = value; }
        }

        public int LengthMax
        {
            get { return lengthMax; }
            set { lengthMax = value; }
        }

        

        public bool IsRolePlay()
        {
            //bool value = false;

            if (playerName.ToLower() != nameDefault.ToLower())
                return false;
            else if (!playerName.Contains("_"))
                return false;
            else if (playerName.Length < lengthMin || playerName.Length > lengthMax)
                return false;
            else
            {
                string name = playerName.Remove(playerName.IndexOf("_"), 1);
                if (!name.Contains("_"))
                    return false;
            }

            if (!Regex.IsMatch(playerName, @"^[a-zA-Z_]+$"))
                return false;
            else
            {
                string name = playerName.Substring(0, playerName.IndexOf("_"));
                string surname = playerName.Substring(playerName.IndexOf("_") + 1);

                if (name.Length < 3 || surname.Length < 4)
                    return false;
                else if (name.Substring(0, 1) != name.Substring(0, 1).ToUpper())
                    return false;
                else if (surname.Substring(0, 1) != surname.Substring(0, 1).ToUpper())
                    return false;
            }

            return true;
        }
    }
}
