using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class Class1
    {
        private string Language;

        // constructor

        public Class1()
        {
            Language = "EN";
        }
        public Class1(string temp)
        {
            Language = temp;    
        }
        public void PrintName(string n, int num, bool blah)
        {
            if (Language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }
            if (Language == "PT")
            {
                System.Console.WriteLine("Oi, " + n + "!");
            }
        }

    }
}
