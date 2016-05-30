using System;
using System.Collections.Generic;

namespace Common.DataAccess.Interfaces
{
    public interface IExceptionHandler
    {
        Dictionary<string, string> Handle(Exception ex);
    }
}
