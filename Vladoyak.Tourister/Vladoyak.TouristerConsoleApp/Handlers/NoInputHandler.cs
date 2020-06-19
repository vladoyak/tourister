using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    public class NoInputHandler : IHandler
    {
        public void Handle()
        {
            Console.WriteLine("No input from user, try writing one of possible commands...");
        }
    }
}
