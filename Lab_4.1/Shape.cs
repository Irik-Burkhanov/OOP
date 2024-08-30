using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace laba_nomer4_part1
{
    public abstract class Shape
    {
        public Color color = Color.Black;
        protected int x, y, r;
        public bool flag = false;

        public Shape(int x1, int y1, int r1)
        {
            x = x1;
            y = y1;
            r = r1;
        }
        public abstract bool CheckPoint(int _x, int _y); 
        public abstract void Draw(Graphics graph); 
    }

    public class Circle : Shape
    {
        public Circle(int x1, int y1, int r1) : base(x1, y1, r1) { }
        public override bool CheckPoint(int dx, int dy)
        {
            dx = x - dx;
            dy = y - dy;
            if (dx * dx + dy * dy <= r * r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Draw(Graphics graph)
        {
            Pen pen;

            if (flag)
            {
                pen = new Pen(color, 10);
            }
            else
            {
                pen = new Pen(color);
            }
            graph.DrawEllipse(pen, x - r, y - r, 2 * r, 2 * r);
        }
    }
}
