using System;
using System.IO;
using System.IO.Compression;
using Consolas.Core;
using GitDesktop.Args;
using LibGit2Sharp;

namespace GitDesktop.Commands
{
    public class BundleCommand : Command
    {
        public void Execute(PushArgs args)
        {
            using (var repo = new Repository(args.Repo))
            {
                repo.Network.Push(repo.Head);
            }
        }
    }
}