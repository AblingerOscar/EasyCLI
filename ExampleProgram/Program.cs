﻿using EasyCli;

namespace ExampleProgram
{
    class Program
    {
        static void Main(string[] args)
            => CliFactory.Create().Run();
    }
}
