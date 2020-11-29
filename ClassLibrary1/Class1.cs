using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Delenie
    {
        public string a, b;
        public Delenie(string a, string b)
        {
            this.a = a;
            this.b = b;

        }
        public string Nomertwo()
        {
            return "" + (Double.Parse(a) / Double.Parse(b));
        }
        public string Clear()
        {
            return "";
        }
        public bool checkinfo()
        {
            if (a.Length == 0 || b.Length == 0)
                return false;
            return true;
        }
    }
}