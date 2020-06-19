using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp
{
    public class Parser
    {
        private TouristerApp _app;

        public Parser(TouristerApp app)
        {
            _app = app;
        }

        public IHandler Parse(string rawInput, ref bool exit)
        {
            string[] words = rawInput.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return new HelpHandler();
            }
            else
            {
                switch (words[0])
                {
                    case "exit":
                        exit = true;
                        return new ExitHandler();                        
                    case "trail":
                        if (words.Length == 1)
                            return new TrailHandler(_app);
                        else
                        {
                            return new TrailByCodeHandler(_app, words[1]);
                        }
                    case "trip":
                        return new TripHandler(_app);
                    case "trailpoint":
                        if (words.Length == 1)
                            return new TrailPointHandler(_app);
                        else
                        {
                            if (words[1] == "-add" && words.Length == 4)
                            {
                                string code = words[2];
                                string name = words[3];
                                return new TrailPointAddingHandler(_app, code, name);
                            }
                            if (words[1] == "-remove" && words.Length == 3)
                            {
                                string code = words[2];
                                return new TrailPointRemovingHandler(_app, code);
                            }
                        }
                        break;
                    default:
                        return new HelpHandler();
                }
            }

            return new HelpHandler();
        }
    }
}
