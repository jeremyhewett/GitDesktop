using Consolas.Core;

namespace GitDesktop.Args
{
    public class DownloadArgs
    {
        public bool Download { get; set; }
        public string Source { get; set; }
        
        public DownloadArgs()
        {
            Source = "../../../aclx.zip";
        }
    }
}
