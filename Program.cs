using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructordemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //course cs1 = new course(2,20000,"Net");
            //Console,WriteLine(cs1.Print());

            courseTostring css1 = new courseTostring(2, 2000, "Net");
            Console.WriteLine( css1); 
        }
    }
}
