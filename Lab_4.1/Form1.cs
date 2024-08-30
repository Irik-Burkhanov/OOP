using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_nomer4_part1
{
    public partial class Form1 : Form
    {
        private Storage storage = new Storage(20);
        private bool chooseCircle = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Check_Down())
            {
                for (int i = 0; i < storage.getLenght(); i++)
                {
                    var shape = storage.getObject(i);
                    if (shape.CheckPoint(e.X, e.Y))
                    {
                        if (shape.flag)
                        {
                            shape.flag = false;
                        }
                        else
                        {
                            shape.flag = true;
                        }
                        chooseCircle = true;
                    }
                }
            }
            else
            {
                int save_i = 0;
                for (int i = 0; i < storage.getLenght(); i++)
                {
                    var shape = storage.getObject(i);
                    if (shape.CheckPoint(e.X, e.Y))
                    {
                        shape.flag = true;
                        save_i = i;
                        chooseCircle = true;
                    }
                }
                for (int i = 0; i < storage.getLenght(); i++)
                {
                    var shape = storage.getObject(i);
                    if (i == save_i)
                    {
                        continue;
                    }
                    else
                    {
                        shape.flag = false;
                    }
                }
            }
            if (chooseCircle == false)
            {
                Circle circle = new Circle(e.X, e.Y, 75);
                storage.CreatItem(circle);
                labelS.Text = "Объектов в хранилище " + Convert.ToString(storage.getLenght());
                var shape = storage.getObject(storage.getLenght() - 1);
                shape.flag = true;
                for (int i = 0; i < storage.getLenght() - 1; i++)
                {
                    var shape_t = storage.getObject(i);
                    shape_t.flag = false;
                }
            }
            pictureBox1.Refresh();
            chooseCircle = false;
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < storage.getLenght(); ++i)
            {
                if (storage.getObject(i).flag)
                {
                    storage.DeleteItem(i);
                    i--;
                }
            }
            if(storage.getLenght() != 0)
            {
                var shape = storage.getObject(storage.getLenght() - 1);
                shape.flag = true;
            }
            labelS.Text = "Объектов в хранилище " + Convert.ToString(storage.getLenght());

            pictureBox1.Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < storage.getLenght(); i++)
            {
                storage.getObject(i).Draw(g);
            }
            labelS.Text = "Объектов в хранилище " + Convert.ToString(storage.getLenght());
        }
        private bool Check_Down()
        {
            if(Control.ModifierKeys == Keys.Control)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
