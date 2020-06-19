using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    public class UnknownCommandHandler : IHandler
    {
        public void Handle()
        {
            Console.WriteLine("Unknown command:( Try another one please...");
        }
    }
}
