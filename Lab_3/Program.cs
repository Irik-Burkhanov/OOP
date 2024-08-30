using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace laba_nomer3
{
    public class Storage<T>
    {
        private int top;
        private int lenght;
        private T[] array;

        public Storage()
        {
            lenght = 0;
            top = 1;
            array = new T[top];
        }
        public Storage(int top) 
        {
            lenght = 0;
            this.top = top;
            array = new T[top];
        }
        public T getObject(int index)
        {
            if (index < top && array[index] != null) 
                return array[index];
            return default;
        }
        public void deletElem(int index) // удаляет элемент под номером index
        {
            if (top > 0)
            {
                if (index <= top)
                {
                    //T[] buffer = new T[top];
                    for (int i = 0, j = 0; i < lenght; i++)
                    {
                        if (i == index)
                        {
                            array[j] = array[i++];
                            j++;
                        }
                        else 
                        { 
                            array[j] = array[i];
                            j++;
                        }
                    }
                    lenght--;
                    //array = buffer;
                }
            }
            else
            {
                Console.WriteLine("В хранилище больше нет объектов");
            }
        }
        public void AddElem(T obj, int index) // вставляет элемент obj на index элемент
        {
            if (lenght == 0)
            {
                array[0] = obj;
                lenght++;
            }
            else
            {
                if (lenght == top)
                {
                    lenght++;
                    int d = 5;
                    T[] buffer = new T[lenght + d];
                    for (int i = 0, j = 0; i < lenght - 1; i++, j++)
                    {
                        if (index == i)
                        {
                            buffer[j] = obj;
                            j++;
                        }
                        buffer[j] = array[i];
                    }
                    array = buffer;
                    top = lenght + d;
                }
                else
                {
                    for (int i = lenght - 1; i >= index; i--) array[i + 1] = array[i];
                    array[index] = obj;
                    lenght++;
                }
            }
        }

        public int Lenght
        {
            get
            {
                return lenght;
            }
        }
        public int Top
        {
            get
            {
                return top;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            Storage<Some_class> s = new Storage<Some_class>(50);
            time.Start();
            for (int i = 0; i < 100; i++)
            {
                Random rd = new Random();
                int value = rd.Next(1, 4);
                switch (value)
                {
                    case 1:
                        value = rd.Next(1, 5);
                        int index;
                        if (s.Lenght > 0) index = rd.Next(s.Lenght);
                        else index = 0;
                        switch (value)
                        {
                            case 1:
                                s.AddElem(new Point(), index);
                                break;
                            case 2:
                                s.AddElem(new Point3d(), index);
                                break;
                            case 3:
                                s.AddElem(new Color_Point(), index);
                                break;
                            case 4:
                                s.AddElem(new Circle(), index);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        for(int j = 0; j < s.Top; j++)
                        {
                            if (s.getObject(j) != null)
                                s.getObject(j).getName();
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        if (s.Lenght > 10)
                        {
                            index = rd.Next(s.Lenght);
                            if (s.getObject(index) != null)
                                s.deletElem(index);
                        }
                        break;
                    default:
                        break;
                }
            }
            time.Stop();
            Console.WriteLine($"Время работы программы: {time.Elapsed}");
        }
    }
}