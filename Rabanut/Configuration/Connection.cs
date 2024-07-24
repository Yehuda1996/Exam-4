using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabanut.Configuration
{
    internal static class Connection
    {
        public static string rabanutPath => Path.Combine(
            Directory.GetCurrentDirectory(),
            "rabanut.xml");
    }
}
