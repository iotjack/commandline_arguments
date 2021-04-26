# ways to parse or handle command line arguments for console apps

1. manually parsing 


2. system.commandline.dragonfruit


https://github.com/dotnet/command-line-api/wiki/DragonFruit-overview



3. NuGet CommandLineParser
https://github.com/commandlineparser/commandline
Define verb commands similar to git commit -a

```
[Verb("add", HelpText = "Add file contents to the index.")]
class AddOptions {
  //normal options here
}
[Verb("commit", HelpText = "Record changes to the repository.")]
class CommitOptions {
  //commit options here
}
[Verb("clone", HelpText = "Clone a repository into a new directory.")]
class CloneOptions {
  //clone options here
}

int Main(string[] args) {
  return CommandLine.Parser.Default.ParseArguments<AddOptions, CommitOptions, CloneOptions>(args)
	.MapResult(
	  (AddOptions opts) => RunAddAndReturnExitCode(opts),
	  (CommitOptions opts) => RunCommitAndReturnExitCode(opts),
	  (CloneOptions opts) => RunCloneAndReturnExitCode(opts),
	  errs => 1);
}
```
