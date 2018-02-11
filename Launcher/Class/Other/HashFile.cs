using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class HashFile
    {
        private string fileName;


        public HashFile()
        {
            fileName = null;
        }

        public HashFile(string filename)
        {
            this.fileName = filename;
        }


        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }


        public string HashMD5()
        {
            if (fileName == null || !File.Exists(fileName)) return null;

            using (MD5 hash = MD5.Create())
            {
                using (FileStream stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(hash.ComputeHash(stream)).Replace("-", String.Empty);
                }
            }
        }

        public string HashSHA1()
        {
            if (fileName == null || !File.Exists(fileName)) return null;

            using (SHA1 hash = SHA1.Create())
            {
                using (FileStream stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(hash.ComputeHash(stream)).Replace("-", String.Empty);
                }
            }
        }
    }
}
