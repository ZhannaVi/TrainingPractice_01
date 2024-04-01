using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popova_0._1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            //Золото

            Console.WriteLine("input inital quantity gold: ");                         //Пользователь вводит кол-во золота,
            int Gold = Convert.ToInt32(Console.ReadLine());                           //которое у него есть.
           
            int gold2 = Gold;                                                        //копирование начального значения, для последующего сравнения


            //Кристалы
            
            Console.WriteLine("How many crystals do u want to buy: ");             //Пользователь вводит кол-во кристаллов,
            int CostCrystal = Convert.ToInt32(Console.ReadLine());                //которое хочет приобрести

            int PriceCrystal = 2;                                                 //Задаем количество кристаллов 
            Console.WriteLine($"the cost of one crystal: {PriceCrystal}");       //Пользователю выводится информация 


            //Рассчет сделки

            int TotalCrystal = CostCrystal * PriceCrystal;                       //Общее кол-во кристаллов, которое может приобрести пользователь
            Gold -= TotalCrystal;                                               //Остаток золота после покупки
           
            Console.WriteLine((gold2 >= TotalCrystal) ? $"The operation was successful, y have gold and crystals: " + $"{Gold}, {CostCrystal}" : "The operation wasn't successfu");    
            //Проверка условия сделки и вывод информации о ней пользователю
           

        }
    }
}
