using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;
namespace NLogDemo
{
    class LogNLog
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string msg)
        {
            Logger.Debug(msg);
        }
        public void LogError(string msg)
        {
            Logger.Error(msg);
        }
        public void LogWarn(string msg)
        {
            Logger.Warn(msg);
        }
        public void LogInfo(string msg)
        {
            Logger.Info(msg);
        }
    }
}
