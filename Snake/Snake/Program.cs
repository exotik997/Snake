using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Point p = new Point (45, 20, '#');
            p.Draw();


            Console.ReadLine();
        }
    }
}
