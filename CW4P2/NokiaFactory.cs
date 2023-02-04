using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4P2
{
    internal class NokiaFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Lumia();
        }

        public IDumb GetDumb()
        {
            return new Asha();
        }
    }
}
