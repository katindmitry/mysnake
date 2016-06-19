using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysnake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            Horizontal_line upline = new Horizontal_line(0, mapWidth - 2, 0, '#');    //Рамочка
            Horizontal_line downline = new Horizontal_line(0, mapWidth - 2, mapHeight -1, '#');
            Vertical_line leftline = new Vertical_line(0, mapHeight - 1, 0, '#');
            Vertical_line rightline = new Vertical_line(0, mapHeight - 1, mapWidth - 2, '#');

            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
