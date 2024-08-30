using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_nomer4_part1
{
    class Storage
    {
        private int top;
        private int lenght = 0;
        public Shape[] array;

        public Storage()
        {
            top = 0;
            array = new Shape[top];
        }
        public Storage(int top)
        {
            this.top = top;
            array = new Shape[top];
        }

        public Shape getObject(int index)
        {
            if (index < top && array[index] != null) return array[index];
            return null;
        }

        public void DeleteItem(int index)
        {
            if (top > 0)
            {
                if (index <= top)
                {
                    for (int i = index; i < lenght; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    lenght--;
                }
            }
        }

        public void CreatItem(Shape item)
        {
            if (lenght >= top)
            {
                Shape[] _bufer = new Shape[top * 2 + 1];
                for (int i = 0; i < top; i++)
                {
                    _bufer[i] = array[i];
                }
                array = _bufer;
                top = top * 2;
            }
            array[lenght] = item;
            lenght++;
        }

        public int getLenght()
        {
            return lenght;
        }
    }
}
