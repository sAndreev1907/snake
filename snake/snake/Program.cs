using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
       
        static void Main(string[] args)
        {


            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(3, 5, '#');
            //p2.Draw();

            HorizontalLine hLine = new HorizontalLine(1, 10, 8, '+');
            hLine.Drow();

            VerticalLines vLine = new VerticalLines(1, 8, 10, '+');
            vLine.Drow();




            Console.ReadLine();

          
        }
    }
}
