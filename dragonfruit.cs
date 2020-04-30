using System;

//Nuget system.commandline.dragonfruit

namespace system_commandline
{
    class Program
    {
        static void Main(int ver=123, string file = "abc.ok", int offset = 0xC000)
        {
            Console.WriteLine(ver);
            Console.WriteLine(file);
            Console.WriteLine(offset.ToString("X"));
        }
    }
}

/*
run xxx.exe -ver 9999

if -h, or wrong command, it'll show

Usage:
  system_commandline [options]

Options:
  --ver <ver>          ver
  --file <file>        file
  --offset <offset>    offset
  --version            Show version information
  -?, -h, --help       Show help and usage information


*/
