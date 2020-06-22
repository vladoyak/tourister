using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp.Parsers
{
    class TripParser : IParser
    {
        private readonly ITouristerApp _app;
        private readonly string[] _words;

        public TripParser(ITouristerApp app, string[] words)
        {
            _app = app;
            _words = words;
        }

        public IHandler Parse()
        {
            if (_words.Length > 1)
            {
                if (_words[1] == "-add" && _words.Length == 6)
                {
                    string code = _words[2];
                    int year = Convert.ToInt32(_words[3]);
                    int month = Convert.ToInt32(_words[4]);
                    int day = Convert.ToInt32(_words[5]);
                    return new TripAddingHandler(_app, code, year, month, day);
                }
                if (_words[1] == "-remove" && _words.Length == 3)
                {
                    string code = _words[2];
                    return new TrailPointRemovingHandler(_app, code);
                }
            }

            return new TripHandler(_app);
        }
    }
}
