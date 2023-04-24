using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Fight
    {
        private int hpplayer;
        private int hpenemy;
        private int[] attackmagic;
        private int[] attacksword;
        private int[] healing;
        private int[] attackenemy;

        public Fight()
        {
            this.hpplayer = 0;
            this.hpenemy = 0;
            this.attackmagic = null;
            this.attacksword = null;
            this.healing = null;
            this.attackenemy = null;
        }
        static int MenuFight()
        {
            int a;
            Int32.TryParse(Console.ReadLine(), out a);
            while (a != 1 && a != 2)
            {
                Int32.TryParse(Console.ReadLine(), out a);
            }
            return a;
        }

        public Fight(int hpplayer, int hpenemy, int[] attackmagic, int[] attacksword, int[] healing, int[] attackenemy)
        {
            Animations animations = new Animations();
            Random rnd = new Random();
            Dialogs dialogs = new Dialogs();
            this.hpplayer = hpplayer;
            this.hpenemy = hpenemy;
            this.attackmagic = attackmagic;
            this.attacksword = attacksword;
            this.healing = healing;
            this.attackenemy = attackenemy;

            bool wynik = true;
            
            while (wynik)
            {
                Console.WriteLine("Twoje życie: " + this.hpplayer + " Życie przeciwnika: " + this.hpenemy);
                Console.WriteLine("1 - Atak 2 - Leczenie");
                switch (MenuFight())
                {
                    case 1:
                        animations.Display("", "strongattack", 65, false, "");
                        this.hpenemy = this.hpenemy - attackmagic[rnd.Next(6)];
                        this.hpplayer = this.hpplayer - attackenemy[rnd.Next(6)];
                        Console.WriteLine("Twoje życie: " + this.hpplayer + " Życie przeciwnika: " + this.hpenemy);
                        dialogs.Enter();
                        break;
                    case 2:
                        this.hpplayer = this.hpplayer + healing[rnd.Next(6)];
                        this.hpplayer = this.hpplayer - attackenemy[rnd.Next(6)];
                        Console.WriteLine("Twoje życie: " + this.hpplayer + " Życie przeciwnika: " + this.hpenemy);
                        dialogs.Enter();
                        break;
                }
                if(this.hpenemy <= 0)
                {
                    wynik = false;
                }
                if (this.hpplayer <= 0)
                {
                    Console.WriteLine("Spróbuj ponownie.");
                    this.hpplayer = 200;
                    this.hpenemy = 100;
                }
            }
        }
    }
}
