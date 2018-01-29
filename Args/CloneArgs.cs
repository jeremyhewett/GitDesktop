using Consolas.Core;

namespace GitDesktop.Args
{
    public class CloneArgs
    {
        public bool Clone { get; set; }
        public string Source { get; set; }
        
        public CloneArgs()
        {
            Source = "../../../aclx.git";
        }
    }
}
