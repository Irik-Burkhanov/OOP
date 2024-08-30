using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba_nomer4_part2.Properties;

namespace laba_nomer4_part2
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();

            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
          
            model.setA(Settings.Default.save_A);
            model.setC(Settings.Default.save_C);
            model.setB(Settings.Default.save_B);
        }

        private void tBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setA(int.Parse(tBoxA.Text));
            }
        }

        private void numUpA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(decimal.ToInt32(numUpA.Value));
        }

        private void tBarA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(decimal.ToInt32(tBarA.Value));
        }

        private void tBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setB(int.Parse(tBoxB.Text));
            }
        }

        private void numUpB_ValueChanged(object sender, EventArgs e)
        {
            model.setB(decimal.ToInt32(numUpB.Value));
        }

        private void tBarB_ValueChanged(object sender, EventArgs e)
        {
            model.setB(decimal.ToInt32(tBarB.Value));
        }

        private void tBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setC(int.Parse(tBoxC.Text));
            }
        }

        private void numUpC_ValueChanged(object sender, EventArgs e)
        {
            model.setC(decimal.ToInt32(numUpC.Value));
        }

        private void tBarC_ValueChanged(object sender, EventArgs e)
        {
            model.setC(decimal.ToInt32(tBarC.Value));
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            tBoxA.Text = model.getA().ToString();
            tBoxB.Text = model.getB().ToString();
            tBoxC.Text = model.getC().ToString();

            numUpA.Value = model.getA();
            numUpB.Value = model.getB();
            numUpC.Value = model.getC();

            tBarA.Value = model.getA();
            tBarB.Value = model.getB();
            tBarC.Value = model.getC();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.save_A = model.getA();
            Settings.Default.save_B = model.getB();
            Settings.Default.save_C = model.getC();
            Settings.Default.Save();
        }
        private void tBoxA_Leave(object sender, EventArgs e)
        {
            tBoxA.Text = model.getA().ToString();
        }
        private void tBoxC_Leave(object sender, EventArgs e)
        {
            tBoxC.Text = model.getC().ToString();
        }
        private void tBoxB_Leave(object sender, EventArgs e)
        {
            tBoxB.Text = model.getB().ToString();
        }

        private void numUpA_Leave(object sender, EventArgs e)
        {
            numUpA.Text = model.getA().ToString();
        }

        private void numUpB_Leave(object sender, EventArgs e)
        {
            numUpB.Text = model.getB().ToString();
        }

        private void numUpC_Leave(object sender, EventArgs e)
        {
            numUpC.Text = model.getC().ToString();
        }
    }

    public class Model
    {
        private int a, b, c;
        public System.EventHandler observers;

        public void setA(int value)
        {
            if (value < 0)
            {
                a = 0;
            }
            else if (value >= 100)
            {
                a = 100;
                b = 100;
                c = 100;
            }
            else if (value > c)
            {
                a = value;
                b = value;
                c = value;
            }
            else if (value > b)
            {
                a = value;
                b = value;
            }
            else
                a = value;
            observers.Invoke(this, null); 
        }
        public void setB(int value)
        {
            if (value > c)
                b = c;
            else if (value < a)
                b = a;
            else
                b = value;
            observers.Invoke(this, null);
        }
        public void setC(int value)
        {
            if (value > 100)
            {
                c = 100;
            }
            else if (value <= 0)
            {
                c = 0;
                a = 0;
                b = 0;
            }
            else if (value <= a)
            {
                a = value;
                b = value;
                c = value;
            }
            else if (value < b)
            {
                b = value;
                c = value;
            }
            else
                c = value;
            observers.Invoke(this, null);
        }
        public int getA()
        {
            return a;
        }
        public int getB()
        {
            return b;
        }
        public int getC()
        {
            return c;
        }
    }
}
