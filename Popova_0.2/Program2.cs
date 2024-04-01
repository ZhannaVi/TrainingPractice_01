using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popova_0._2
{
    internal class Program2
    {
        class ChessBoard
        {
            static void Main(string[] args)
            {
                char x1, y1, x2, y2;

                //Ввод координат первого поля

                Console.WriteLine("Input coordinates x1 and y1 via enter: ");
                x1 = char.Parse(Console.ReadLine());
                y1 = char.Parse(Console.ReadLine());


                //Ввод координат второго поля
                Console.WriteLine("Input coordinates x2 and y2 via enter: ");
                x2 = char.Parse(Console.ReadLine());
                y2 = char.Parse(Console.ReadLine());


                //Проверка, являются ли поля одного цвета
                bool isSameColor = CheckSameColor(x1, y1, x2, y2);
                if (isSameColor)
                {
                    Console.WriteLine("Fields x1, y1 and x2, y2 are the same color");
                }
                else
                {
                    Console.WriteLine("Fields x1, y1 and x2, y2 are of different colors");
                }

                //Отрисовка шахматной доски
                DrawChessboard();

            }

            
            static bool CheckSameColor(char x1, char y1, char x2, char y2)
            {
                //Поля одного цвета,
                //если сумма численных значений координат одинакова
                return ((x1+y1)%2) == ((x2+y2)%2);
            }

            static void DrawChessboard()
            {
                //Вывод шахматной доски
                //с координатами и буквами по краям
                Console.WriteLine(" a b c d e f g h");
                for(int i = 1; i < 8; i++)
                {
                    Console.Write(i);
                    for (char j = 'a'; j <= 'h'; j++)
                    {
                        if ((i+j) % 2 == 0)
                        {
                            //Черное поле
                            Console.Write(" #");
                        }
                        else
                        {
                            //Белое поле
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine(" " + i);
                }
                Console.WriteLine(" a b c d e f g h");
            }
        }
    }
}
