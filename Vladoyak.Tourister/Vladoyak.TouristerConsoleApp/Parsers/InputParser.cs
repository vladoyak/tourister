using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp.Parsers
{
    public class InputParser : IParser
    {
        private readonly ITouristerApp _app;
        private readonly string _rawInput;

        public InputParser(ITouristerApp app, string rawInput)
        {
            _app = app;
            _rawInput = rawInput;
        }

        public IHandler Parse()
        {
            string[] words = _rawInput.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                var command = words[0];
                switch (command)
                {
                    case "help":
                        return new HelpHandler(words);
                    case "exit":
                        return new ExitHandler();
                    case "trail":
                        if (words.Length == 1)
                            return new TrailHandler(_app);
                        else
                        {
                            return new TrailByCodeHandler(_app, words[1]);
                        }
                    case "trip":
                        return new TripParser(_app, words).Parse();
                    case "trailpoint":
                        return new TrailPointParser(_app, words).Parse();
                    case "save":
                        return new SaveParser(_app, words).Parse();
                    default:
                        return new UnknownCommandHandler();
                }
            }

            return new NoInputHandler();
        }
    }
}
