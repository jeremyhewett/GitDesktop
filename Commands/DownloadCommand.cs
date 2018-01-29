using System;
using System.IO;
using System.IO.Compression;
using Consolas.Core;
using GitDesktop.Args;
using LibGit2Sharp;

namespace GitDesktop.Commands
{
    public class DownloadCommand : Command
    {
        public void Execute(DownloadArgs args)
        {
            string dest = Path.ChangeExtension(args.Source, ".git");
            Console.WriteLine($"Unzipping{args.Source} to {dest} ...");
            ZipFile.ExtractToDirectory(args.Source, dest);
        }
    }
}