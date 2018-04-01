using System;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class RoleRule
    {
        private readonly string name;
        private readonly string title;
        private readonly string info;


        public RoleRule(string name, string title, string info)
        {
            this.name = name;
            this.title = title;
            this.info = info;
        }


        public string Name
        {
            get { return this.name; }
        }

        public string Title
        {
            get { return this.title; }
        }

        public string Info
        {
            get { return this.info; }
        }


        public override string ToString()
        {
            return String.Format("{0} - {1}", name, title);
        }
    }
}
