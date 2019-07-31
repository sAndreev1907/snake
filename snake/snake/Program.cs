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

            Console.SetBufferSize(120, 30);
            HorizontalLine leftLine = new HorizontalLine(1, 119, 1, '*');
            HorizontalLine rightLine = new HorizontalLine(1, 119, 28, '*');
            VerticalLines upLine = new VerticalLines(1, 28, 1, '*');
            VerticalLines downLine = new VerticalLines(1, 28, 119, '*');
            leftLine.Drow();
            rightLine.Drow();
            upLine.Drow();
            downLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Drow();






            Console.ReadLine();

          
        }
    }
}
