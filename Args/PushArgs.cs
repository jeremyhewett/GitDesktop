using Consolas.Core;

namespace GitDesktop.Args
{
    public class PushArgs
    {
        public bool Push { get; set; }
        public string Repo { get; set; }
        
        public PushArgs()
        {
            Repo = "../../../aclx";
        }
    }
}
