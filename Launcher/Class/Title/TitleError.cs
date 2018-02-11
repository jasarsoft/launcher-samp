using System;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class TitleError : MessageTitle, IMessageTitle
    {
        //default contructor
        public TitleError() : base()
        {
            //noting
        }


        public override string Caption
        {
            get
            {
                return String.Format("{0} | Greška", base.Caption);
            }
        }


        public override string ToString()
        {
            return base.Caption;
        }
    }
}
