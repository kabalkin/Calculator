using System;

namespace Addons
{
     public class BadProxyException:Exception
    {
        public BadProxyException(string message):base(message)
        {

        }
    }
}