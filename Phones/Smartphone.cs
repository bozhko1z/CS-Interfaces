using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Smartphone : ISmartPhone, IBrowsable
    {
        public string Call(string number)
        {

            return $"Calling... {number}";
        }
        public string Browse(string url)
        {
            return $"Browsing: {url}!";
        }

        

    }
}
