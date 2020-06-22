using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class TrailPointRemovingHandler : IHandler
    {
        private readonly ITouristerApp _app;
        private readonly string _code;

        public TrailPointRemovingHandler(ITouristerApp app, string code)
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