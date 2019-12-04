using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace clowncheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Frac a = new Frac(1, 2);
            //Frac g = new Frac(1.7);
            Frac r = 1 + a + a + 2;
            Console.WriteLine(r);
            
        }
    }
}
