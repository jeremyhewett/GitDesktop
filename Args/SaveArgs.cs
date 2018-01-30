using Consolas.Core;

namespace GitDesktop.Args
{
    public class SaveArgs
    {
        public bool Save { get; set; }
        public string Repo { get; set; }
        public string Message { get; set; }
        
        public SaveArgs()
        {
            Repo = "../../../aclx";
            Message = "Updated";
        }
    }
}
