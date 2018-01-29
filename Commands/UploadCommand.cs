using System;
using System.IO;
using System.IO.Compression;
using Consolas.Core;
using GitDesktop.Args;
using LibGit2Sharp;

namespace GitDesktop.Commands
{
    public class UploadCommand : Command
    {
        public void Execute(UploadArgs args)
        {
            string dest = Path.ChangeExtension(args.Repo, "zip");
            Console.WriteLine($"Zipping {args.Repo} to {dest} ...");
            ZipFile.CreateFromDirectory(args.Repo, dest);
        }
    }
}