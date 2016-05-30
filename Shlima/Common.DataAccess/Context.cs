using System;
using System.Collections.Generic;
using System.Data.Entity;
using Common.DataAccess.Interfaces;

namespace Common.DataAccess
{
    public class Context : DbContext, IContext
    {
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }

        public Context(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public Dictionary<string, string> Errors { get; private set; }

        public bool SaveChanges(IExceptionHandler exceptionHandler)
        {
            try
            {
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Errors = exceptionHandler.Handle(ex);
                return false;
            }
        }
    }
}
