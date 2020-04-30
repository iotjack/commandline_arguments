using System;
using System.Diagnostics;
using System.Linq;

namespace manual_parsing
{
    class Program
    {
        //like this -v 100 -f "some file name" -offset 0x8000
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var verstring = args.Select((value, index) => (value, index)).SingleOrDefault(x => x.value.StartsWith("-v", StringComparison.OrdinalIgnoreCase));
            if (verstring.value != null)
            {
                var ver = args[verstring.index + 1];

                Console.WriteLine(ver);
            }

            var filestring = args.Select((value, index) => (value, index)).SingleOrDefault(x => x.value.StartsWith("-f", StringComparison.OrdinalIgnoreCase));
            if (filestring.value != null)
            {
                var file = args[filestring.index + 1];

                Console.WriteLine(file);
            }


        }
    }
}
