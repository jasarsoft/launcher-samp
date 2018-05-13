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

        public SampRegistry(string name) : this()
        {
            this.playerName = name;
        }

        public SampRegistry(string name, string path) : this(name)
        {
            this.pathName = path;
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
                    if (rk == null) return false;

                    if (rk.GetValue(RegKey.PATH_NAME, null) == null) return false;
                    if (rk.GetValue(RegKey.PLAYER_NAME, null) == null) return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Valid()
        {
            object value;

            try
            {
                using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(subKey))
                {
                    value = rk.GetValue(RegKey.PATH_NAME, null);
                    if (value == null) throw new ArgumentNullException();
                    if (!File.Exists(Convert.ToString(value))) throw new FileNotFoundException();

                    value = rk.GetValue(RegKey.PLAYER_NAME, null);
                    if (value == null) throw new ArgumentNullException();
                    if (Convert.ToString(value).Length == 0) throw new ArgumentException();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Create()
        {
            try
            {
                using (RegistryKey rk = Registry.CurrentUser.CreateSubKey(subKey))
                {
                    rk.SetValue(RegKey.PATH_NAME, this.pathName, RegistryValueKind.String);
                    rk.SetValue(RegKey.PLAYER_NAME, this.playerName, RegistryValueKind.String);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            object value;

            try
            {
                using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(subKey))
                {
                    value = rk.GetValue(RegKey.PATH_NAME, null);
                    if (value == null) throw new ArgumentNullException();
                    this.pathName = Convert.ToString(value);

                    value = rk.GetValue(RegKey.PLAYER_NAME, null);
                    if (value == null) throw new ArgumentNullException();
                    this.playerName = Convert.ToString(value);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Write()
        {
            try
            {
                using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(subKey, true))
                {
                    rk.SetValue(RegKey.PATH_NAME, this.pathName, RegistryValueKind.String);
                    rk.SetValue(RegKey.PLAYER_NAME, this.playerName, RegistryValueKind.String);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Default()
        {
            this.playerName = "Nick";
            this.pathName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) +
                            "\\Rockstart Games\\Grand Theft Auto San Andreas\\gta_sa.exe";
        }

        public void SetPath(string path)
        {
            this.pathName = String.Format("{0}\\gta_sa.exe", path);
        }

        public string GetPath()
        {
            return this.pathName.Remove(this.pathName.Length - (RegKey.PATH_NAME.Length + 1));
        }
    }
}
