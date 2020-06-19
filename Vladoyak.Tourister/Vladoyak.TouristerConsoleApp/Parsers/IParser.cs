using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp.Parsers
{
    public interface IParser
    {
        IHandler Parse();
    }
}
