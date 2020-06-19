using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class TrailPointRemovingHandler : IHandler
    {
        private readonly TouristerApp _app;
        private readonly string _code;

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