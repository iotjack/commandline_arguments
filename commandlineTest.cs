using System;
using System.Collections.Generic;
using CommandLine;
using System.Linq;

namespace CommandLineParserTest
{

    class Program
    {

        public class Options
        {
            [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
            public bool Verbose { get; set; }

            [Option('d', "deploy", Required = false, HelpText = "Deploy to remote server")]
            public bool Deploy { get; set; }
        }


        static void Main(string[] args)
        {
            //first argument is expected to be filename. 
            if (args.Length < 1)
            {
                HandleInputError(null);
                Environment.Exit(1);
            }
            var fn = args[0];

            var result = CommandLine.Parser.Default.ParseArguments<Options>(args[1..]);
            //MapResult((Options opts) => RunOptions(fn, opts), //in case parser sucess
            //errs => HandleInputError(errs)); //in  case parser fail
            RunOptions(fn, result.Value);
            Console.WriteLine(result.Errors.Count());

        }


        static void RunOptions(string fn, Options opts)
        {
            //handle options
            Console.WriteLine(fn);
            if (opts.Deploy)
            {
                Console.WriteLine("deploy");
            }
            if (opts.Verbose)
            {
                Console.WriteLine("version");
            }
        }
        static void HandleInputError(IEnumerable<Error> errs)
        {
            Console.WriteLine("Usage: application filename [-v/--verbose true/false] [-d/--deploy true/false]");
            if (errs!=null)
            {
                foreach(var e in errs)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
