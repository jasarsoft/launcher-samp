using System;

namespace Jasarsoft.SAMP
{
    public class About
    {
        private readonly string title;
        private readonly string version;
        private readonly string date;
        private readonly string license;
        private readonly string copyright;
        private readonly string description;


        public About()
        {
            this.title = "SAMP Launcher";
            this.version = "0.1 Alpha";
            this.date = "09.09.2017.";
            this.license = "Aphace License v2.0";
            this.copyright = "Edin Jašarević - Jašarsoft";
            this.description = "SAMP Launcher opis";
        }

        public string Title
        {
            get { return this.title; }
        }

        public string Version
        {
            get { return this.version; }
        }

        public string Date
        {
            get { return this.date; }
        }
        public string License
        {
            get { return this.license; }
        }

        public string Copyright
        {
            get { return this.copyright; }
        }

        public string Description
        {
            get { return this.description; }
        }
    }
}
