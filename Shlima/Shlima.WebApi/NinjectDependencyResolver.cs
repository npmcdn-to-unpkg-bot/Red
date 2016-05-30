using System;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;

namespace Shlima.WebApi
{
    // Provides a Ninject implementation of IDependencyScope
    // which resolves services using the Ninject container.
    internal class NinjectDependencyScope : IDependencyScope
    {
        private IResolutionRoot _resolver;

        public NinjectDependencyScope(IResolutionRoot resolver)
        {
            _resolver = resolver;
        }

        public object GetService(Type serviceType)
        {
            if (_resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            return _resolver.TryGet(serviceType);
        }

        public System.Collections.Generic.IEnumerable<object> GetServices(Type serviceType)
        {
            if (_resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            return _resolver.GetAll(serviceType);
        }

        public void Dispose()
        {
            var disposable = _resolver as IDisposable;
            disposable?.Dispose();

            _resolver = null;
        }
    }

    // This class is the resolver, but it is also the global scope
    // so we derive from NinjectScope.
    internal class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        readonly IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel) : base(kernel)
        {
            _kernel = kernel;
            AddBindings();
        }

        private void AddBindings()
        {
            _kernel.Bind<DataAccess.Interfaces.IContext>().To<DataAccess.Context>();
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(_kernel.BeginBlock());
        }
    }
}