﻿using System;

namespace structs
{
    public struct Point
    {
        private int x { get; set; }
        private int y { get; set; }
        public Point(int x, int y)
        {
            this.x = x; // afecta a propriedade x
            this.y = y; // "           "        y
        }
        public void Add(int offx, int offy)
        {
            this.x = this.x + offx;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Program prg = new Program();
            Point p2 = new Point();
            Point p1 = new Point(10, 20);

            p1.Add(2, 3);

            object o = p1;          // box
            Point p3 = (Point)o;    // unbox

            Console.WriteLine(p1);

        }
    }
}
