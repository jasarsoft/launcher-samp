
namespace Jasarsoft.Launcher.SAMP
{
    internal abstract class MessageTitle : IMessageTitle
    {
        private readonly string caption;
        

        //constructor
        public MessageTitle()
        {
            this.caption = "SAMP - Launcher";
        }


        public virtual string Caption
        {
            get { return this.caption; }
        }


        public override string ToString()
        {
            return caption;
        }
    }
}
