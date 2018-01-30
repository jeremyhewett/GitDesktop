using Consolas.Core;

namespace GitDesktop.Args
{
    public class OpenArgs
    {
        public bool Open { get; set; }
        public string Source { get; set; }
        
        public OpenArgs()
        {
            Source = "../../../aclx.git";
        }
    }
}
