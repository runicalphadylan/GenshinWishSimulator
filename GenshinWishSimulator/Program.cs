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
                if (pc5 == 89 || rng <= pity)
                {
                    int rng5star = rnd.Next(16);
                    Reward5star(rng5star);
                    pc5 = 0;
                    pt5++;
                    twishcount++;
                    pity = 6;
                }
                else if (pc4 == 9 || rng <= 57)
                {
                    int rng4star = rnd.Next(40);
                    Reward4star(rng4star);
                    pc4 = 0;
                    pc5++;
                    pt4++;
                    twishcount++;
                    if (pc5 >= 74) { pity += 60; } else continue;
                }
                else
                {
                    int rng3star = rnd.Next(22);
                    Reward3star(rng3star);
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

        static void Reward3star(int rnd3star)
        {
            Random rnd = new Random();
            string[] reward3star = { "Black Tassel", "Bloodstained Greatsword",
                    "Cool Steel", "Debate Club", "Emerald Orb", "Ferrous Shadow",
                    "Fillet Blade", "Halberd", "Harbinger of Dawn", "Magic Guide",
                    "Messenger", "Otherworldly Story", "Raven Bow", "Recurve Bow",
                    "Sharpshooter's Oath", "Skyrider Greatsword", "Skyrider Sword",
                    "Slingshot", "Thrilling Tales of Dragonslayers", "Traveler's Handy Sword",
                    "Twin Nephrite", "White Iron Greatsword", "White Taseel"};
            Console.WriteLine("***\t\t" + reward3star[rnd3star]);
        }

        static void Reward4star(int rnd4star)
        {
            Random rnd = new Random();
            string[] reward4star = { "Amber", "Barbara", "Beidou", "Bennett",
                    "Candace", "Charlotte", "Chevreuse", "Chongyun", "Collei", 
                    "Diona", "Dori", "Faruzan", "Fischl", "Freminet", "Gaming",
                    "Gorou", "Kachina", "Kaeya", "Kaveh", "Kirara", "Kujou Sara",
                    "Kuki Shinobu", "Layla", "Lisa", "Lynette", "Mika", "Ningguang",
                    "Noelle", "Razor", "Rosaria", "Sayu", "Sethos", "Shikanoin Heizou",
                    "Sucrose", "Thoma", "Xiangling", "Xingqiu", "Xinyan", "Yanfei",
                    "Yaoyao", "Yunjin"};
            Console.WriteLine("****\t\t" + reward4star[rnd4star]);
        }

        static void Reward5star(int rnd5star)
        {
            Random rnd = new Random();
            string[] reward5star = { "Jean", "Diluc",
                    "Mona", "Qiqi", "Keqing", "Tignari",
                    "Dehya", "Skyward Blade", "Skyward Atlas", "Skyward Pride",
                    "Skyward Harp", "Skyward Spine", "Wolf's Gravestone", "Aquilla Favonia",
                    "Primodial Jade-Winged Spear", "Lost Prayers to Sacred Winds", "Amos Bow"};
            Console.WriteLine("*****\t\t" + reward5star[rnd5star]);
        }
    }
}
