using System;
using System.Collections.Generic;

namespace AdventOfCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var m = new MoveSub2();
            m.MoveSub();
            Console.WriteLine($"Down: {m.down} Forward: {m.forward} Product: {m.down*m.forward}  ");
        }
    }
}
