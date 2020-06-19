using System;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;
using Vladoyak.TouristerConsoleApp.Parsers;

namespace Vladoyak.TouristerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new TouristerApp();
            app.Init();

            IHandler _handler = new IntroductionHandler();
            _handler.Handle();
                       
            while (!(_handler is ExitHandler))
            {
                string rawInput = Console.ReadLine();
                _handler = new InputParser(app, rawInput).Parse();
                _handler.Handle();
            }
        }
    }
}
