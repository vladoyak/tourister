using System;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new TouristerApp();
            app.Init();

            IHandler _handler = new HelpHandler();
            _handler.Handle();

            bool exit = false;
            while (!exit)
            {
                string rawInput = Console.ReadLine();
                _handler = new Parser(app).Parse(rawInput, ref exit);
                _handler.Handle();
            }
        }
    }
}
