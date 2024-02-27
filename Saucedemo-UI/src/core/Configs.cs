using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo_UI.src.core
{
    internal class Configs
    {
        public static string DRIVER_PATH = Environment.GetEnvironmentVariable("DRIVER_PATH");
        public static string BASE_URL = "https://www.saucedemo.com/v1/";
    }
}
