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

            Walls walls = new Walls(80, 25);
            walls.Draw();                               
                                  
            Point p = new Point(4, 5, '*');   // Отрисовка змейки
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$'); //Создание еды
            Point food = foodCreator.CreateFood();
            food.Draw();
           
            while(true)  // змейка кушает
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
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
