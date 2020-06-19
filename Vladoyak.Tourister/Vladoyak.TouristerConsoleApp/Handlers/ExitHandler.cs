using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    public class ExitHandler : IHandler
    {
        public void Handle()
        {
            Console.WriteLine("Application is closing...");
        }
    }
}
