using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelftCreateIOC.Test
{
    internal class RandomGuidProvider:IRandomGuidProvider
    {
      public  Guid GetRandomGuid
        {
            get
            {
                return Guid.NewGuid();  
            }
        }
    }
}
