using Ninject;
using Ninject.Modules;

namespace DI
{
    public enum ResolverModuleType
    {
        Default,
        Dal,
        Bl,
        Web
    }
    public class DResovler
    {
        public T ResolveByType<T>(ResolverModuleType mType)
        {
            return GetKernel(mType).Get<T>();
        }

        public IKernel GetKernel(ResolverModuleType mType)
        {
            IKernel result;
            switch (mType)
            {
                case ResolverModuleType.Bl:
                    {
                        result = NiInjectKernel.GetBlKernel();
                    }
                    break;
                case ResolverModuleType.Dal:
                    {
                        result = NiInjectKernel.GetDalKernel();
                    }
                    break;
                case ResolverModuleType.Web:
                    {
                        result = NiInjectKernel.GetWebKernel();
                    }
                    break;
                default:
                    result = NiInjectKernel.GetWebKernel();
                    break;
            }
            return result;
        }
    }

    class NiInjectKernel
    {
        static volatile IKernel _kernelDal;
        static volatile IKernel _kernelBl;
        static volatile IKernel _kernelWeb;
        static readonly object Locker = new object();

        public static IKernel GetDalKernel()
        {
            if (_kernelDal == null)
            {
                lock (Locker)
                {
                    if (_kernelDal == null)
                    {
                        _kernelDal = new StandardKernel(new NinjectSettings() { AllowNullInjection = true }, new NinjectDalModule());
                    }
                }
            }

            return _kernelDal;
        }

        public static IKernel GetBlKernel()
        {
            if (_kernelBl == null)
            {
                lock (Locker)
                {
                    if (_kernelBl == null)
                    {
                        _kernelBl = new StandardKernel(new NinjectSettings() { AllowNullInjection = true }, new NinjectBlModule());
                    }
                }
            }

            return _kernelBl;
        }

        public static IKernel GetWebKernel()
        {
            if (_kernelWeb == null)
            {
                lock (Locker)
                {
                    if (_kernelWeb == null)
                    {
                        _kernelWeb = new StandardKernel(new NinjectSettings { AllowNullInjection = true }, new INinjectModule[] { new NinjectDalModule(), new NinjectBlModule() });
                    }
                }
            }

            return _kernelWeb;
        }
    }
}
