using System;
using System.Collections.Generic;
using System.Text;

namespace RichnessSoft.Common
{
    public interface ILogService
    {
        void Fatal(string message);
        void Error(string message);
        void Warn(string message);
        void Info(string message);
        void Debug(string message);
    }
}
