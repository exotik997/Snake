using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отрисовка рамки
            Console.SetWindowSize(150, 40);
            Console.SetBufferSize(150, 40);
            HorizontalLine top = new HorizontalLine(0, 149, 0, '_');
            HorizontalLine bot = new HorizontalLine(0, 149, 38, '_');
            VerticalLine left = new VerticalLine(1, 38, 0, '|');
            VerticalLine right = new VerticalLine(1, 38, 149, '|');
            top.Draw();
            bot.Draw();
            left.Draw();
            right.Draw();

            //Отрисовка змейки
            Point p = new Point (4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();      
        
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(10);
                snake.Move();
            }
        }
    }
}
