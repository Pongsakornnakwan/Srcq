using log4net.Appender;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichnessSoft.Common.Extensions
{
    public static class Log4netExtensions
    {
        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory, IAppender[] appenders)
        {
            factory.AddProvider(new Log4NetProvider(appenders));
            return factory;
        }
    }
}
