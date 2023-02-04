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

        // Parameterized constructor to take enum value from manufacturers argued to manu
        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;
        }

        // Switches through various cases of types of products and prints names of products to Console
        public void CheckProducts() 
        {
            ISmart smart;
            IDumb dumb;
            switch (manu)
            {
                // Samsung Manufacturers
                case (Manufacturers.Samsung):
                    factory = new SamsungFactory();
                    smart = factory.GetSmart();
                    dumb = factory.GetDumb();

                    Console.WriteLine(smart.getName());
                    Console.WriteLine(dumb.getName());

                    break;

                // HTC Manufacturers 
                case (Manufacturers.HTC):
                    factory = new HTCFactory();
                    smart = factory.GetSmart();
                    dumb = factory.GetDumb();

                    Console.WriteLine(smart.getName());
                    Console.WriteLine(dumb.getName());

                    break;

                // Nokia Manufacturers
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
