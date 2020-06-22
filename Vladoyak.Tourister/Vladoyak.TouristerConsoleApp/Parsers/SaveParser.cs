using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp.Parsers
{
    public class SaveParser : IParser
    {
        private readonly TouristerApp _app;
        private readonly string[] _words;

        public SaveParser(TouristerApp app, string[] words)
        {
            _app = app;
            _words = words;
        }

        public IHandler Parse()
        {
            return new SaveHandler(_app);
        }
    }
}
