using System;
using System.IO;
using System.IO.Compression;
using Consolas.Core;
using GitDesktop.Args;
using LibGit2Sharp;

namespace GitDesktop.Commands
{
    public class CloneCommand : Command
    {
        public void Execute(CloneArgs args)
        {
            Repository.Clone(args.Source, $"../../../{Path.GetFileNameWithoutExtension(args.Source)}");
        }
    }
}