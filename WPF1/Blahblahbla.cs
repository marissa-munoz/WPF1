//Marissa Munoz
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class Blahblahbla
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public Blahblahbla()
        {
            Name = "";
            Address = ""; //Address = string.Empty;
            ZipCode = 0;
        }
        public Blahblahbla(string name, string address, int zipCode)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            //tim did this stuff
            string ans = $"Hello {Name}, your address is {Address} and your zip code is {ZipCode}";
            return ans;
        }
    }
}
