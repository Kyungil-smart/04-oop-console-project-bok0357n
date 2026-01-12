using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Game
    {
        Map map;
        Player player;
        Rules rules;
        PrintText printText;

        public void Run()
        {
            lnit();

            while(true)
            {
                // 맵 초기화

                // 플레이어 이동
            }
        }

        void lnit()
        {
            map = new Map();
            player = new Player();
            rules = new Rules();
            printText = new PrintText();
        }
    }
    
}
