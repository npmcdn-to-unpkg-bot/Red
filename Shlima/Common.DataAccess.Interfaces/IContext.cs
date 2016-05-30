using System.Collections.Generic;

namespace Common.DataAccess.Interfaces
{
    public interface IContext
    {
        int SaveChanges();

        Dictionary<string, string> Errors { get; }

        bool SaveChanges(IExceptionHandler exceptionHandler);
    }
}
