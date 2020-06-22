using Microsoft.Extensions.DependencyInjection;
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
            // dependency injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ITouristerApp, TouristerApp>()
                .BuildServiceProvider();

            // get app instance
            var app = serviceProvider.GetService<ITouristerApp>();
            app.Init();

            // introduction
            IHandler _handler = new IntroductionHandler();
            _handler.Handle();
                       
            // parsing and handling commands till the end
            while (!(_handler is ExitHandler))
            {
                string rawInput = Console.ReadLine();
                _handler = new InputParser(app, rawInput).Parse();
                _handler.Handle();
            }
        }
    }
}
