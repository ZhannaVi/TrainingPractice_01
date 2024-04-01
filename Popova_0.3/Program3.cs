using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popova_0._3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose a language (English it's (1) and Russian it's (2)): ");

            int English;
            int Russian;
            int lenguage = Convert.ToInt32(Console.ReadLine());

            switch (lenguage)
            {
                case 1:
                    Console.WriteLine("Greetings, dear friend. You got into the league of legends. \n You're going to play for Morgana today.\n\n You have 4 attacks. \n q = dark bonds (Morgana releases a sphere of dark energy in the chosen direction. The sphere deals magic damage 80hp and immobilizes the first hit enemy, dealing 80hp),\n\n w = exhausted shadow (infects the selected area. All opponents who stand on the cursed land receive magic damage 60hp,\n\n e = black shield (Creates a protective barrier around itself that blocks weakening and absorbs magic damage until it is pierced or the shield dissipates. Shield strength 80 hp),\n\n r = shackles of souls (Morgana binds nearby enemy champions with energy chains, dealing 175 hp damage to them and reducing their movement speed.\n\n Let the fight begin! You need to defeat Ronas to save yourself and the village.)");
                    break;
                case 2:
                    Console.WriteLine("Приветствую, дорогой друг. Ты попал в лигу легенд.\n Сегодня ты будешь играть за моргану.\n У тебя есть 4 атаки.\n\n q = темные узы (Моргана выпускает в выбранном направлении сферу темной энергии. Сфера наносит магический урон 80хп и обездвиживает первого пораженного врага, нанося 80хп),\n\n w = измученная тень (заражает выбранную область. Все противники, которые стоят на проклятой земле, получают магический урон 60хп),\n\n e = черный щит (Создает вокруг себя защитный барьер, который блокирует ослабления и поглощает магический урон, пока его не пробьют или щит не рассеется. Прочность щита 80 хп),\n\n r = оковы душ (Моргана сковывает находящихся рядом вражеских чемпионов цепями энергии, нанося им урон  175 хп и снижая их скорость передвижения.\n\n Да начнется бой! Вам нужно победить Ронаса, чтобы спасти себя и деревню)");
                    break;
            }

            Console.WriteLine("\n");

            Console.WriteLine("Предупреждение!!! Сама игра идет, только на английском языке!!!");

            Console.WriteLine("\n");

            int Morgana = 630;

            Console.WriteLine("U have 630hp");

            int q = 80;
            int w = 60;
            int e = 80;
            int r = 175;

            Console.WriteLine("\n");

            int Boss = 520;

            Console.WriteLine("Boss has 520hp");

            Console.WriteLine("\n");

            Console.WriteLine("U attacks first: ");

            Console.WriteLine("\n");

            int attacksBoss = 0;
            int count = 1;
            //Цикл жизни персонажи и повторение атак
            while (Morgana >= 0 && Boss >= 0)
            {
                Console.WriteLine($"Раунд {count}");
                char attack = Convert.ToChar(Console.ReadLine());

                switch (attack)
                {
                    case 'q':
                        Boss -= q;
                        Console.WriteLine($"HP Boss: {Boss}");
                        break;
                    case 'w':
                        Boss -= w;
                        Console.WriteLine($"HP Boss: {Boss} ");
                        break;
                    case 'e':
                        Boss -= e;
                        Console.WriteLine($"HP Boss:  {Boss}");
                        break;
                    case 'r':
                        Boss -= r;
                        Console.WriteLine($"HP Boss: {Boss}");
                        break;
                }
                //Создание рандома аттак босса
                Random rnd = new Random();
                int rndValue = rnd.Next(80, 180);

                //Подсчет хп Морганы после урона Босса
                Console.WriteLine(rndValue);
                Morgana -= rndValue;

                Console.WriteLine($"Boss attacks{rndValue}");

                Console.WriteLine($"Your hp:{Morgana} ");
                count += 1;
            }
        }
    }
}
