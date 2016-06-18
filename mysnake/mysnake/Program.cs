using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point( 1, 3, '*' );
            p1.Draw();

            Point p2 = new Point( 4, 5, '#' );
            p2.Draw();

            Horizontal_line line = new Horizontal_line( 1, 20, 10, '*' );
            line.Draw();

            Vertical_line vline = new Vertical_line( 20, 1, 9, '*' );
            vline.Draw();

                   
            Console.ReadLine();
        }
    }
}
