using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamemathstudy
{
    class Type1
    {
        static void Main(string[] args)
        {
            var a = 20;
            var b = new int[] { 10, 20, 30 };
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
