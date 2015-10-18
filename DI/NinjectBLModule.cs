using BL.Common;
using Ninject.Modules;

namespace DI
{
    class NinjectBlModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBlCommon>().To<BlCommon>();
        }
    }
}
