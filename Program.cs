using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp12
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.SetWindowSize((int)Border.Width, (int)Border.Height + 5);
            Snake.Init();
        }
    }
}
