using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CLAP;

namespace podcast_search
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new Commands();

            Parser.Run(args, commands);
        }
    }
}
