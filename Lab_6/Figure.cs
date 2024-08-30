using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms.VisualStyles;

namespace Lab6
{
    public abstract class Figure 
    {
        protected int x, y, r;
        public bool flag = false;
        protected Color _color = Color.Black;

        protected Figure()
        {
            x = 0;
            y = 0;
            r = 0;
        }

        protected Figure(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        protected Figure(Figure obj)
        {
            x = obj.x;
            y = obj.y;
            r = obj.r;
            flag = obj.flag;
        }
        
        public virtual void Move(int _x, int _y, int _r)
        {
            x += _x;
            y += _y;
            r += _r;
            if (r < 10)
            {
                r = 10;
            }
        }
        
        public virtual void ChangeCol(Color c)
        {
            _color = c;
        }
        public abstract bool CheckPoint(int _x, int _y);
        public abstract bool CanMove(int width, int height, int _x, int _y, int _r);
        public abstract void Draw(Graphics graph);        
    }

    public class Circle : Figure
    {
        public Circle() : base() { }
        public Circle(int x, int y, int r) : base(x, y, r) { }
        public Circle(Circle obj) : base(obj) { }
        public override bool CheckPoint(int _x, int _y)
        {
            _x = x - _x;
            _y = y - _y;
            return (_x*_x + _y*_y <= r*r);
        }

        public override void Draw(Graphics graph)
        {
            Pen pen;
            if (flag)
            {
                pen = new Pen(_color, 5);
            }
            else
            {
                pen = new Pen(_color);
            }
            graph.DrawEllipse(pen, x-r, y-r, 2*r, 2*r);
        }

        public override bool CanMove( int width, int height, int _x, int _y, int _r)
        {
            return (x + _x - (r + _r) > 0 && x + _x + (r + _r) < width && y + _y - (r + _r) > 0 &&
                    y + _y + (r + _r) < height);
        }
    }

    public class Square : Figure
    {
        public Square() : base() { }
        public Square(int x, int y, int r) : base(x, y, r) { }
        public Square(Square obj) : base(obj) { }
        public override bool CheckPoint(int _x, int _y)
        {
            return (_x >= (x - r) && _x <= x + r && _y >= (y - r) && _y <= (y + r));
        }

        public override void Draw(Graphics graph)
        {
            Pen pen;
            if (flag)
            {
                pen = new Pen(_color, 5);
            }
            else
            {
                pen = new Pen(_color);
            }

            graph.DrawRectangle(pen, x - r, y - r, 2 * r, 2 * r);
        }

        public override bool CanMove( int width, int height, int _x=0, int _y=0, int _r=0)
        {
            return (x + _x - (r + _r) > 0 && x + _x + (r + _r) < width && y + _y - (r + _r) > 0 &&
                    y + _y + (r + _r) < height);
        }
    }

    public class Triangle : Figure
    {
        public Triangle() : base() { }
        public Triangle(int x, int y, int r) : base(x, y, r) { }
        public Triangle(Triangle obj) : base(obj) { }

        public override bool CheckPoint(int _x, int _y)
        {
            var p1 = (((int)(x - r / 2 * Math.Sqrt(3)) - 1) - _x) * ((y - r) - (y + r / 2)) - (x - ((int)(x - r / 2 * Math.Sqrt(3)) - 1)) * ((y + r / 2) - _y);
            var p2 = (x - _x) * ((y + r / 2) - (y - r)) - (((int)(x + r / 2 * Math.Sqrt(3)) + 1) - x) * ((y - r) - _y);
            var p3 = (((int)(x + r / 2 * Math.Sqrt(3)) + 1) - _x) * ((y + r / 2) - (y + r / 2)) - (((int)(x - r / 2 * Math.Sqrt(3)) - 1) - ((int)(x + r / 2 * Math.Sqrt(3)) + 1)) * ((y + r / 2) - _y);
            return (p1 <= 0 && p2 <= 0 && p3 <= 0 || p1 >= 0 && p2 >= 0 && p3 >= 0);
        }

        public override void Draw(Graphics graph)
        {
            Point[] points = new Point[4];
            points[0].X = (int)(x - r / 2 * Math.Sqrt(3)) - 1;
            points[0].Y = (y + r / 2);
            points[1].X = x;
            points[1].Y = y - r;
            points[2].X = (int)(x + r / 2 * Math.Sqrt(3)) + 1;
            points[2].Y = (y + r / 2);
            points[3].X = points[0].X;
            points[3].Y = points[0].Y;

            Pen pen;
            if (flag)
            {
                pen = new Pen(_color, 5);
            }
            else
            {
                pen = new Pen(_color);
            }
            graph.DrawLines(pen, points);
        }
        public override bool CanMove(int width, int height, int _x, int _y, int _r)
        {
            return (x + _x - (r + _r) > (0 - (r + _r) / 6) + 3 && x + _x + (r + _r) < width + (r + _r) / 6 - 3 && y + _y - (r + _r) > 0 &&
                    y + _y + (r + _r) < ((int)height + (r + _r) / 2) - Math.Sqrt(3));
        }
    }
}