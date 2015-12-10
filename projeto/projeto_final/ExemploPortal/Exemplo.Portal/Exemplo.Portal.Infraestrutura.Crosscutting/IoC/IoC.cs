using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.ServiceLocation;
using Exemplo.Portal.Infraestrutura.Crosscutting.IoC.Dependencias;

namespace Exemplo.Portal.Infraestrutura.Crosscutting.IoC
{
    public class IoC
    {
        public IUnityContainer Container { get; private set; }

        public IoC ()
	    {
            Container = new UnityContainer();
            RegisterConfig.Register(Container);

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(Container));
	    }
    }
}
