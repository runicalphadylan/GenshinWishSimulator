using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace GenshinWishSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean running = true;
            while (running)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("How many wishes would you like to do");
                Console.WriteLine("=====================================");
                Wish();
                Console.WriteLine("================");
                Console.WriteLine("Type (n) to stop");
                Console.WriteLine("================");
                string confirm = Console.ReadLine();
                if (confirm == "n")
                {
                    running = false;
                } else {}
            }


        }

        static void Wish()
        {
            Random rnd = new Random();
            int pc4 = 0;
            int pc5 = 0;
            int pt3 = 0;
            int pt4 = 0;
            int pt5 = 0;
            int pity = 6;
            int twishcount = 0;
            float chance = 0;


            Console.Write("Enter number: ");
            int wishcount = Convert.ToInt32(Console.ReadLine());

            for (int i = wishcount; i > 0; i--)
            {
                int rng = rnd.Next(1000);
                if (pc5 == 89)
                {
                    Console.WriteLine("*****");
                    pc5 = 0;
                    pt5++;
                    twishcount++;
                    pity = 6;
                }
                else if (rng <= pity)
                {
                    Console.WriteLine("*****");
                    pc5 = 0;
                    pt5++;
                    twishcount++;
                    pity = 6;
                }
                else if (pc4 == 9)
                {
                    Console.WriteLine("****");
                    pc4 = 0;
                    pc5++;
                    pt4++;
                    twishcount++;
                    if (pc5 >= 74) { pity += 60; } else continue;
                }
                else if (rng <= 57)
                {
                    Console.WriteLine("****");
                    pc4 = 0;
                    pc5++;
                    pt4++;
                    twishcount++;
                    if (pc5 >= 74) { pity += 60; } else continue;
                }
                else
                {
                    Console.WriteLine("***");
                    pc4++;
                    pc5++;
                    pt3++;
                    twishcount++;
                    if (pc5 >= 74) { pity += 60; } else continue;
                }


            }
            float chance2 = Convert.ToSingle(pity);
            chance = chance2 / 10;
            Console.WriteLine($"Total Wishes:" + twishcount);
            Console.WriteLine($"*****:" + pt5);
            Console.WriteLine($"****:" + pt4);
            Console.WriteLine($"***:" + pt3);
            Console.WriteLine($"5star rate = {chance}%");
            Console.WriteLine("5star pity = " + pc5);
            Console.WriteLine("4star pity = " + pc4);
        }

    }
}
