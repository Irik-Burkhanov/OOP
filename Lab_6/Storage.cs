using System;

namespace Lab6
{
    public class Storage
    {
        private Figure[] arr;
        private int size;
        private int count;

        public Storage()
        {
            size = 0;
            arr = new Figure[size];
            count = 0;
        }

        public Storage(int size)
        {
            this.size = size;
            arr = new Figure[size];
            count = 0;
        }
        
        public int Count
        {
            get
            {
                return count;
            }
        }

        public Figure GetObj(int index)
        {
            return arr[index];
        }
        
        public void AddObj(Figure obj)
        {
            if (count >= size)
            {
                int newSize = size + 10;
                Figure[] _bufer = new Figure[newSize];
                for (int i = 0; i < size; i++)
                {
                    _bufer[i] = arr[i];
                }
                arr = _bufer;
                size = newSize;
            }
            arr[count] = obj;
            count++;
        }
        
        public void DeleteObj(int index)
        {
            if (size > 0)
            {
                if (index <= size)
                {
                    for (int i = index; i < count; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    count--;
                }
                else
                    Console.WriteLine("Индекс больше чем размер хранилища");
            }
            else Console.WriteLine("В хранилище больше нет объектов");
        }
    }
}