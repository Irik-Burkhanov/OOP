using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            model.Change(e.X, e.Y, pictureBox1.Width, pictureBox1.Height, comboBox1.SelectedIndex);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            model.Draw_a_figure(e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.ChangeColor(comboBox2.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.DeleteFigure();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            model.KeyDown(e, pictureBox1.Width, pictureBox1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                model.colordia(colorDialog1.Color);
            }
        }
    }

    public class Model
    {
        protected Storage _storage;
        protected bool chooseFigure;

        public System.EventHandler observers;

        public Model()
        {
            _storage = new Storage(20);
            chooseFigure = false;
        }

        public void Change(int x, int y, int width, int height, int figure_index)
        {
            for (int i = 0; i < _storage.Count; i++)
            {
                var figure = _storage.GetObj(i);
                if (figure.CheckPoint(x, y))     
                {
                    if (figure.flag)
                    {
                        figure.flag = false;
                    }
                    else
                    {
                        figure.flag = true;
                    }
                    chooseFigure = true;
                }
            }
            if (chooseFigure == false)
            {
                if (x + 75 <= width && x - 75 >= 0 && y - 75 >= 0)
                {
                    switch (figure_index)
                    {
                        case 0:
                            if (y + 75 <= height)
                            {
                                Circle circle = new Circle(x, y, 75);
                                _storage.AddObj(circle);
                            }
                            break;
                        case 1:
                            if (y + 75 <= height)
                            {
                                Square square = new Square(x, y, 75);
                                _storage.AddObj(square);
                            }
                            break;
                        case 2:
                            if (y + (75/2 - Math.Sqrt(3)) <= height)
                            {
                                Triangle triangle = new Triangle(x, y, 75);
                                _storage.AddObj(triangle);
                            }
                            break;
                    }
                }
            }
            observers.Invoke(this, null);
            chooseFigure = false;
        }

        public void DeleteFigure()
        {
            for (int i = 0; i < _storage.Count; ++i)
            {
                if (_storage.GetObj(i).flag)
                {
                    _storage.DeleteObj(i);
                    i--;
                }
            }
            observers.Invoke(this, null);
        }

        public void Draw_a_figure(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < _storage.Count; i++)
            {
                _storage.GetObj(i).Draw(g);
            }
            //observers.Invoke(this, null);
        }

        public void ChangeColor(int color_index)
        {
            for (int i = 0; i < _storage.Count; i++)
            {
                if (_storage.GetObj(i).flag)
                {
                    switch (color_index)
                    {
                        case 0:
                            _storage.GetObj(i).ChangeCol(Color.Black);
                            break;
                        case 1:
                            _storage.GetObj(i).ChangeCol(Color.Blue);
                            break;
                        case 2:
                            _storage.GetObj(i).ChangeCol(Color.Red);
                            break;
                    }
                }
            }
            observers.Invoke(this, null);
        }

        public void colordia(Color c)
        {

            for (int i = 0; i < _storage.Count; i++)
            {
                if (_storage.GetObj(i).flag)
                {
                    _storage.GetObj(i).ChangeCol(c);
                    continue;
                }
            }
            observers.Invoke(this, null);
        }
        public void KeyDown(KeyEventArgs e, int width, int height)
        {
            int dx = 0;
            int dy = 0;
            int dr = 0;
            switch (e.KeyCode)
            {   case Keys.A: dx = -2; break;
                case Keys.D: dx = 2; break;
                case Keys.W: dy = -2; break;
                case Keys.S: dy = 2; break;
                case Keys.ShiftKey: dr = 1; break;
                case Keys.ControlKey: dr = -1; break;
            }
            for (int i = 0; i < _storage.Count; i++)
            {
                if (_storage.GetObj(i).flag && _storage.GetObj(i).CanMove(width, height, dx, dy, dr)) 
                    _storage.GetObj(i).Move(dx, dy, dr);
            }
            observers.Invoke(this, null);
        }
    }
}