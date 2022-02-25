using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelftCreateIOC.DependencyInjection
{
    public class ServicesDescriptor
    {
        public Type ServiceType { get; }
        public object Implementation { get; set; }
        public ServiceLifeTime ServiceLifeTime { get;}
        public Type ImplementationType { get; }
        public ServicesDescriptor(object inplementation, ServiceLifeTime serviceLifeTime)
        {
            ServiceType = inplementation.GetType();
            Implementation=inplementation;
            ServiceLifeTime=serviceLifeTime;

        }
        public ServicesDescriptor(Type ServiceType, ServiceLifeTime serviceLifeTime)
        {
            this.ServiceType = ServiceType;
          
            ServiceLifeTime = serviceLifeTime;

        }
        public ServicesDescriptor(Type ServiceType, Type Implementation,ServiceLifeTime serviceLifeTime)
        {
            this.ServiceType = ServiceType;

            ServiceLifeTime = serviceLifeTime;
            this.ImplementationType = Implementation;

        }
    }
}
