﻿using System;
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
            Console.SetBufferSize(80, 25); //ограничение окна
                                 
            Horizontal_line upline = new Horizontal_line( 0, 78, 0, '*' );    //Рамочка
            Horizontal_line downline = new Horizontal_line( 0, 78, 24, '*' );
            Vertical_line leftline = new Vertical_line( 0, 0, 24, '*' );
            Vertical_line rightline = new Vertical_line(78, 0, 24, '*');

            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();         
            

                   
            Console.ReadLine();
        }
    }
}
