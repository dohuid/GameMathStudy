using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamemathstudy
{
    class Study2
    {
        //열거형 타입 선언
        enum CAL { SUM, SUB, MUL, DIV }

        static void Main(string[] args)
        {
            //입력처리
            Console.WriteLine("첫번째 숫자를 입력하세요 : ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("두번쨰 숫자를 입력하세요 : ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("0:덧셈, 1:뻴셈, 2:곱셈, 3:나눗셈");
            int op = Int32.Parse(Console.ReadLine());
            
            switch ((CAL)op)
            {
                case CAL.SUM:
                    Console.WriteLine(num1 + num2);
                    break;
                case CAL.SUB:
                    Console.WriteLine(num1 - num2);
                    break;
                case CAL.MUL:
                    Console.WriteLine(num1 * num2);
                    break;
                case CAL.DIV:
                    Console.WriteLine(num1 / num2);
                    break;
            }
        }
    }
}
