using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesXY
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public string GetQuadrant()
        {
            if (X > 0 && Y > 0) return "Перша чверть";
            if (X < 0 && Y > 0) return "Друга чверть";
            if (X < 0 && Y < 0) return "Третя чверть";
            if (X > 0 && Y < 0) return "Четверта чверть";
            return "Точка знаходиться на осі";
        }
    }
}
