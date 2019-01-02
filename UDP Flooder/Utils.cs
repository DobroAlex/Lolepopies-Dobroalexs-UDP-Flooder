using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace UDP_Flooder
{
    class Utils
    {
        public static byte[] GenerateRandomByteArray(int length)
        {
            var RNG = new RNGCryptoServiceProvider();
            byte[] retVal = new byte[length];
            RNG.GetBytes(retVal);
            RNG.Dispose();
            return retVal;
        }
    }
}
