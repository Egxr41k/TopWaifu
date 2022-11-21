using Microsoft.Extensions.Logging;
using ShikimoriSharp;
using ShikimoriSharp.Bases;
using System;

namespace ConsoleRequestTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //думаю всю работу нужно начинать отсюда, и пока не трогать основной проект
            // я хз что такое логгер, погугли и пофикси это пожалуйста
            var client = new ShikimoriClient(logger, new ClientSettings( // я не особо вкуриваю что это такое,
                                                                         // но все эти значения я брал, когда создавал приложение
                                                                       "whatthefuckiactuallydo",
                                                                       "FwfBTUqGwGREtoud70r2kUEWRDU0HU6Xt-K-vt3tb20",
                                                                       "qzHTGirY2Duwk-tBJ5FjcEZOlpmscx-gednmc_rRbJU"));

            // дальше короче будем брать код отсюда
        }
    }
}
