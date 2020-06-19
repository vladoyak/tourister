using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class TrailPointRemovingHandler : IHandler
    {
        private TouristerApp _app;
        private string _code;

        public TrailPointRemovingHandler(TouristerApp app, string code)
        {
            _app = app;
            _code = code;
        }

        public void Handle()
        {
            _app.RemoveTrailPoint(_code);
        }
    }
}