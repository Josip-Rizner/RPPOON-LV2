using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    interface ILogger
    {
        //void Log(string message);     4. zadatak

        void Log(ILogable data);
    }
}
