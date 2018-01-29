using Consolas.Core;

namespace GitDesktop.Args
{
    public class UploadArgs
    {
        public bool Upload { get; set; }
        public string Repo { get; set; }
        
        public UploadArgs()
        {
            Repo = "../../../aclx.git";
        }
    }
}
