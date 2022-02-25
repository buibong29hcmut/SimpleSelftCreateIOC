using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelftCreateIOC.DependencyInjection
{
    internal class DiContainer
    {
        private  List<ServicesDescriptor> _servicesDescriptors;
        public DiContainer(List<ServicesDescriptor> servicesDescriptors)
        {
            this._servicesDescriptors = servicesDescriptors;
        }
        public object GetService(Type serviceType)
        {
            var desciptor = _servicesDescriptors.
                            SingleOrDefault(x => x.ServiceType.Equals(serviceType));
            if (desciptor == null)
            {
                throw new Exception($"Services of type {serviceType.Name} isn't registerd");

            }
            if (desciptor.Implementation != null)
            {
                return desciptor.Implementation;
            }
            var actualType = desciptor.ImplementationType ?? desciptor.ServiceType;
            if (actualType.IsAbstract || actualType.IsInterface)
            {
                throw new Exception("Can't instantiate abstract classes or interfaces");
            }
            var constructorInfo = actualType.GetConstructors().First();
            var parameters = constructorInfo.GetParameters().Select(x => GetService(x.ParameterType)).ToArray();

           
            
            var implementation = Activator.CreateInstance(actualType, parameters);

            if (desciptor.ServiceLifeTime == ServiceLifeTime.SingleTon)
            {
                desciptor.Implementation = implementation;
            }

            return implementation;
        }
        public T GetService<T>()
        {
           return  (T)(GetService(typeof(T)));
        }
    }
}
