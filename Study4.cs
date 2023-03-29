using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamemathstudy
{
    class Study4
    {
        static void Main(string[] args)
        {
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(var item in array) //타입에 맞는 값을 가져옴
            {
                Console.WriteLine(item);
            }
            //var or object : 모든 타입을 가져올 수 있음
        }
    }
}
