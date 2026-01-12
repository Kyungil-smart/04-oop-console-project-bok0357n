using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Map
    {
        readonly Random random = new Random();

        char[,] map;
        int width;
        int height;

        public void lnit(Random rand)
        {
            width = random.Next(10, 21);
            height = random.Next(10, 21);

            map = new char[width, height];

            for (int i = 0; i < map.GetLength(0); i++) 
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if ( i == 0 || j == 0 || i == width -1 || j == height - 1)
                    {
                        map[i, j] = Define.WALL;
                    }
                    else
                    {
                        map[i, j] = Define.EMPTY;
                    }
                }
            }
        }

        public void PrintMap()
        {
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
}
