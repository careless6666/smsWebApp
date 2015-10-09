using DAL.Common;
using Ninject.Modules;

namespace DI
{
    public class NinjectDalModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDalCommon>().To<DalCommon>();
        }
    }
}
