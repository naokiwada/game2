using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int x = 0;
            while(i < 11)
            {
                Console.WriteLine(i + "+"+x+"="+ (i + x));
                x = i + x;
                i++;
            }
        }
    }
}
