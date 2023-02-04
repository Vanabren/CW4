using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4P2
{
    internal interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }
}
