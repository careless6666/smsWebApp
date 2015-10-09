using System;
using System.Web.Mvc;
using System.Web.Routing;
using DI;
using Ninject;

namespace SmsWebApplication
{
    public class NInjectControllerFactory : DefaultControllerFactory
    {
        readonly IKernel _kernel;

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            IController res = null;
            try
            {
                if (controllerType == null)
                    controllerType = typeof(Controllers.HomeController);
                res = (IController)_kernel.Get(controllerType);
            }
            catch (Exception)
            {
                res = null;
            }
            return res;
        }

        public NInjectControllerFactory()
        {
            _kernel = new DResovler().GetKernel(ResolverModuleType.Web);
            //_kernel.Load(new NinjectModelModule());
        }
    }
}