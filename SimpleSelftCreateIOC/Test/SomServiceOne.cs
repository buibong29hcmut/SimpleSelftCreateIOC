using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelftCreateIOC.Test
{
    public class SomServiceOne:ISomeService
    {
        private IRandomGuidProvider _randomGuidProvider;
        public SomServiceOne(IRandomGuidProvider randomGuidProvider)
        {
            this._randomGuidProvider = randomGuidProvider;
        }
        public void WriteMessage()
        {
            Console.WriteLine(_randomGuidProvider.GetRandomGuid.ToString());
        }
    }
}
