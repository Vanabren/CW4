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
            ISmart smart;
            IDumb dumb;
            switch (manu)
            {
                case (Manufacturers.Samsung):
                    factory = new SamsungFactory();
                    smart = factory.GetSmart();
                    dumb = factory.GetDumb();

                    Console.WriteLine(smart.getName());
                    Console.WriteLine(dumb.getName());

                    break;

                case (Manufacturers.HTC):
                    factory = new HTCFactory();
                    smart = factory.GetSmart();
                    dumb = factory.GetDumb();

                    Console.WriteLine(smart.getName());
                    Console.WriteLine(dumb.getName());

                    break;

                case (Manufacturers.Nokia):
                    factory = new NokiaFactory();
                    smart = factory.GetSmart();
                    dumb = factory.GetDumb();

                    Console.WriteLine(smart.getName());
                    Console.WriteLine(dumb.getName());

                    break;

                default:
                    break;

            }
        }
    }
}
