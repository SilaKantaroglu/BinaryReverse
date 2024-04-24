using System;
using System.Collections.Generic;


namespace Algoritmalar2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir tam sayının tersini (reverse) alıp,
            //bu ters sayının ikili (binary) gösterimini oluşturmayı amaçlayan program

            int a = 53556;
            int b = 0;
            while (a != 0)
            {
                b = b * 10 + a % 10;
                a /= 10;
            }

            string s = " ";
            for (int i = 0; i < 16; i++)
            {
                if ((b & 1) == 1)
                {
                    s = "1" + s;
                }
                else s = "0" + s;
                b = b >> 1;
            }
            Console.WriteLine(s);

        }
    }
    }





