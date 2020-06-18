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
                string[] words = rawInput.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (words.Length == 0)
                {
                    _handler = new HelpHandler();
                    _handler.Handle();
                }
                else
                {
                    switch (words[0])
                    {
                        case "exit":
                            exit = true;
                            break;
                        case "trail":
                            if (words.Length == 1)
                                _handler = new TrailHandler(app);
                            else
                                _handler = new TrailByCodeHandler(app, words[1]);
                            break;
                        case "trip":
                            _handler = new TripHandler(app);
                            break;
                        default:
                            _handler = new HelpHandler();
                            break;
                    }

                    _handler.Handle();                  
                }
            }
        }
    }
}
