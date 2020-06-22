using System;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class SaveHandler : IHandler
    {
        private ITouristerApp _app;

        public SaveHandler(ITouristerApp app)
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