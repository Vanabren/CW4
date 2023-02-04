using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4P2
{
    internal class SamsungFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }

        public IDumb GetDumb()
        {
            return new Genie();
        }
    }
}
