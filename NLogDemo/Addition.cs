using System;
using System.Collections.Generic;
using System.Text;
using NLog;
namespace NLogDemo
{
    class Addition
    {
       readonly LogNLog NLog = new LogNLog();
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
            if (a == 0 || b==0)
            {
                NLog.LogDebug("Debug successful: sum()");
                NLog.LogError("Expecting null value");
                NLog.LogWarn("a or b should not equal to zero");
            }
            int c = a + b;
            NLog.LogDebug("Debug successful: sum()");
            NLog.LogInfo("Sum method passed, result " + c);
        }
    }
}
