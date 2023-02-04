using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4P2
{
    internal class PhoneTypeChecker
    {
        IPhoneFactory factory;
        Manufacturers manu;

        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;
        }

        public void CheckProducts() 
        {
            switch (manu)
            {
                case (Manufacturers.Samsung):
                    factory = new SamsungFactory();
                    factory.GetSmart();
                    factory.GetDumb();
                    break;

                case (Manufacturers.HTC):
                    factory = new HTCFactory();
                    factory.GetSmart();
                    factory.GetDumb();
                    break;

                case (Manufacturers.Nokia):
                    factory = new NokiaFactory();
                    factory.GetSmart();
                    factory.GetDumb();
                    break;

                default:
                    break;

            }
        }
    }
}
