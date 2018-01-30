using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Consolas.Core;
using GitDesktop.Args;
using LibGit2Sharp;

namespace GitDesktop.Commands
{
    public class OpenCommand : Command
    {
        public void Execute(OpenArgs args)
        {
            var dest = $"../../../{Path.GetFileNameWithoutExtension(args.Source)}";
            Repository.Clone(args.Source, dest);
            using (var repo = new Repository(dest))
            {
                var branchName = "development";
                Branch trackedBranch = repo.Branches[$"origin/{branchName}"];
                Debug.Assert(trackedBranch.IsRemote);
                var branch = repo.CreateBranch(branchName, trackedBranch.Tip);
                repo.Branches.Update(branch, b => b.TrackedBranch = trackedBranch.CanonicalName);
                LibGit2Sharp.Commands.Checkout(repo, branch);
            }
        }
    }
}