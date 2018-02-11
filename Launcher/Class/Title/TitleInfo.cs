using System;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class TitleInfo : MessageTitle, IMessageTitle
    {
        //contructor
        public TitleInfo() : base()
        {
            //noting
        }


        public override string Caption
        {
            get
            {
                return String.Format("{0} | Info", base.Caption);
            }
        }


        public override string ToString()
        {
            return base.Caption;
        }
    }
}
