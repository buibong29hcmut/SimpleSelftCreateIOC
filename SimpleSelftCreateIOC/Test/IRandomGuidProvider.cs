using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelftCreateIOC.Test
{
    public interface IRandomGuidProvider
    {
        Guid GetRandomGuid { get; }
    }
}
