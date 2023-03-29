using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamemathstudy
{
    class Study5
    {
        static void Main(string[] args)
        {
            ArrayList number = new ArrayList();

            for(int i = 0; i < 10; i++)
            {
                number.Add(i); //리스트에 0~9까지 넣기
            }

            foreach(int num in number)
            {
                Console.WriteLine(num); //리스트 출력
            }
        }
    }
}
