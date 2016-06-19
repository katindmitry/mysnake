using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Point p = new Point(4, 5, '*');   // Отрисовка змейки
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$'); //Создание еды
            Point food = foodCreator.CreateFood();
            food.Draw();
           
            while(true)  // змейка кушает
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
                                             
        }
    }
}
