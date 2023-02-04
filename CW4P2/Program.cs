using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (Manufacturers m in Enum.GetValues(typeof(Manufacturers))) 
            {
                PhoneTypeChecker check = new PhoneTypeChecker(m);
                check.CheckProducts();
            }
            
        }
    }
}
