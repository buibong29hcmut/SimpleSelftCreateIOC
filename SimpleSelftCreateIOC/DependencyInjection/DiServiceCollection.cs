using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelftCreateIOC.DependencyInjection
{
    internal class DiServiceCollection
    {
        private List<ServicesDescriptor> _servicesDescriptor= new List<ServicesDescriptor>();
        public void RegisterSingleton<TService>()
        {
            _servicesDescriptor.Add(new ServicesDescriptor(typeof(TService), ServiceLifeTime.SingleTon));
        }
        
        public void RegisterSingleton<TService, TImplementation>() where TImplementation:TService
        {
            _servicesDescriptor.Add(new ServicesDescriptor(typeof(TService), typeof(TImplementation), ServiceLifeTime.SingleTon));
        }
        public void RegisterTransient<TService>(TService implemectation)
        {
            _servicesDescriptor.Add(new ServicesDescriptor(implemectation, ServiceLifeTime.Transient));
        }
        public void RegisterTransient<TService,TImplementation>()
        {
            _servicesDescriptor.Add(new ServicesDescriptor(typeof(TService),typeof(TImplementation), ServiceLifeTime.Transient));
        }
        public void RegisterSingleton<TService>(TService implemectation)
        {
            _servicesDescriptor.Add(new ServicesDescriptor(implemectation, ServiceLifeTime.SingleTon));
        }
        public DiContainer GenerateContainer()
        {
            return new DiContainer(_servicesDescriptor);
        }
        

    }
}
