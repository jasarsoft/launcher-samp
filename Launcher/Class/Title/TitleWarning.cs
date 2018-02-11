using System;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class TitleWarning : MessageTitle, IMessageTitle
    {
        //contructor
        public TitleWarning() : base()
        {
            //nothing
        }


        public override string Caption
        {
            get
            {
                return String.Format("{0} | Upozorenje", base.Caption);
            }
        }


        public override string ToString()
        {
            return base.Caption;
        }
    }
}
