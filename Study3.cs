using CalculationProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProj
{
    public class GuGuDan
    {
        public void Print() //구구단 전체 출력 , i = 2 j = 1 상태로 시작
        {
            for (int i = 2; i < 10; i++) 
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
        }
        public void PrintDan(int startDan, int lastDan) //구구단 일부 출력
        {
            for (int i = startDan; i < lastDan + 1; i++) //단의 수만큼 반복
            {
                for (int j = 1; j < 10; j++) // j는 1부터 9까지 반복
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
        }
    }
}

namespace gamemathstudy
{
    class Study3
    {
        static void Main(string[] args)
        {
            int StartDan, LastDan;
            GuGuDan myGugudan = new GuGuDan();

            //전체 출력
            myGugudan.Print();

            //부분 출력
            Console.WriteLine("시작단을 입력하세요 : ");
            StartDan = Int32.Parse(Console.ReadLine());
            Console.WriteLine("끝단을 입력하세요 : ");
            LastDan = Int32.Parse(Console.ReadLine());
            myGugudan.PrintDan(StartDan, LastDan);
        }
    }
}


