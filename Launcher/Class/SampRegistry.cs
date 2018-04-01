using System;
using System.IO;
using Microsoft.Win32;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class SampRegistry
    {
        private string pathName;
        private string playerName;
        private readonly string subKey;

        private struct RegKey
        {
            public const string PATH_NAME = "gta_sa_exe";
            public const string PLAYER_NAME = "PlayerName";
        }


        //default constructor
        public SampRegistry()
        {
            this.pathName = String.Empty;
            this.playerName = String.Empty;
            this.subKey = @"Software\SAMP";
        }

        public string PathName
        {
            get { return this.pathName; }
            set { this.pathName = value; }
        }

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }


        public bool Check()
        {
            try
            {
                using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(subKey))
                {
                    if (rk != null)
                    {
                        object value;

                        value = rk.GetValue(RegKey.PATH_NAME, null);
                        if (value == null) return false;

                        value = rk.GetValue(RegKey.PLAYER_NAME, null);
                        if (value == null) return false;

                        return true;
                    }

                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Valid()
        {
            if (!this.Check()) return false;

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(subKey))
            {
                if (rk != null)
                {
                    string path, name;

                    try { path = Convert.ToString(rk.GetValue(RegKey.PATH_NAME, null)); }
                    catch { return false; }
                    if (!System.IO.File.Exists(path)) return false;

                    try { name = Convert.ToString(rk.GetValue(RegKey.PLAYER_NAME, null)); }
                    catch { return false; }
                    if (!name.Contains("_")) return false;

                    return true;
                }

                return false;
            }
        }

        public bool Create()
        {
            using (RegistryKey rk = Registry.CurrentUser.CreateSubKey(subKey))
            {
                if (rk != null)
                {
                    rk.SetValue(RegKey.PATH_NAME, this.pathName, RegistryValueKind.String);
                    rk.SetValue(RegKey.PLAYER_NAME, this.playerName, RegistryValueKind.String);

                    return true;
                }
            }

            return false;
        }

        public bool Read()
        {
            if (!this.Check()) return false;

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(subKey))
            {
                if (rk != null)
                {
                    this.pathName = Convert.ToString(rk.GetValue(RegKey.PATH_NAME, null));
                    this.playerName = Convert.ToString(rk.GetValue(RegKey.PLAYER_NAME, null));
                    return true;
                }
            }

            return false;
        }

        public bool Write()
        {
            if (!this.Check()) return false;

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(subKey, true))
            {
                if (rk != null)
                {
                    rk.SetValue(RegKey.PATH_NAME, this.pathName, RegistryValueKind.String);
                    rk.SetValue(RegKey.PLAYER_NAME, this.playerName, RegistryValueKind.String);

                    return true;
                }
            }

            return false;
        }

        public void Default()
        {
            this.PlayerName = "Ime_Prezime";
            this.pathName = Directory.GetCurrentDirectory() + @"\gta_sa.exe";
        }
    }
}
