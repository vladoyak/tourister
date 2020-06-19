using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp.Parsers
{
    class TrailPointParser : IParser
    {
        private readonly TouristerApp _app;
        private readonly string[] _words;

        public TrailPointParser(TouristerApp app, string[] words)
        {
            _app = app;
            _words = words;
        }

        public IHandler Parse()
        {
            if (_words.Length > 1)
            {
                if (_words[1] == "-add" && _words.Length == 4)
                {
                    string code = _words[2];
                    string name = _words[3];
                    return new TrailPointAddingHandler(_app, code, name);
                }
                if (_words[1] == "-remove" && _words.Length == 3)
                {
                    string code = _words[2];
                    return new TrailPointRemovingHandler(_app, code);
                }
            }

            return new TrailPointHandler(_app);
        }
    }
}
