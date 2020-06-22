using System;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class SaveHandler : IHandler
    {
        private TouristerApp _app;

        public SaveHandler(TouristerApp app)
        {
            _app = app;
        }

        public void Handle()
        {
            // save all changes
            _app.Save();
            Console.WriteLine("All changes have been saved.");
        }
    }
}