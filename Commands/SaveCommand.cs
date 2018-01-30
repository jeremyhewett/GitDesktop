using System;
using Consolas.Core;
using GitDesktop.Args;
using GitDesktop.Shared;
using LibGit2Sharp;

namespace GitDesktop.Commands
{
    public class SaveCommand : Command
    {
        public void Execute(SaveArgs args)
        {
            Signature author = new Signature(Config.Username, Config.Email, DateTime.Now);
            using (var repo = new Repository(args.Repo))
            {
                LibGit2Sharp.Commands.Stage(repo, "*");
                try
                {
                    repo.Commit(args.Message, author, author);
                }
                catch (EmptyCommitException) { }
                repo.Network.Push(repo.Head);
            }
        }
    }
}