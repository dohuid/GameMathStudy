using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamemathstudy
{
    class Name
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int level = 50;

            bool isAlive = (hp > 0);
            bool isHightLevel = (level >= 40);
            // a = 살아있는 고렙 유저인가요?
            bool a = isAlive && isHightLevel;
            // b = 살아있거나, 고랩 유저이거나 둘 중 하나인가요?
            bool b = isAlive || isHightLevel;
            // c = 죽은 유저인가요?
            bool c = !isAlive;
        }
    }
}
