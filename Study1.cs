using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamemathstudy
{
    class Study1
    {
        enum CAL { SUM, SUB, MUL, DIV}
        //열거형 0부터 시작

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            CAL cal = CAL.SUB;

            switch (cal)
            {
                case CAL.SUM:
                    Console.WriteLine(a + b);
                    break;
                case CAL.SUB:
                    Console.WriteLine(a - b);
                    break;
                case CAL.MUL:
                    Console.WriteLine(a * b);
                    break;
                case CAL.DIV:
                    Console.WriteLine(a / b);
                    break;
            }
        }
    }
}
