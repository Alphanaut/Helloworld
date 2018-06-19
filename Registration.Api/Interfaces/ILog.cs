using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Api.Interfaces
{
    public interface ILog
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Error(Exception e, string message, params object[] args);
        void Error(Exception e);

    }
}
