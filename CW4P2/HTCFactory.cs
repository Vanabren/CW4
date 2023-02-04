using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4P2
{
    internal class HTCFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Titan();
        }

        public IDumb GetDumb()
        {
            return new Primo();
        }
    }
}
